using Steam4NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamGameBooster
{
    public partial class Form1 : Form
    {
        private ISteamClient012 _steamClient012;
        private ISteamApps001 _steamApps001;

        private int pipe;
        private int user;

        private bool isRunning;

        private Form frm;

        public Form1()
        {
            InitializeComponent();

            isRunning = false;
        }

        public void CreateDefaultConfig()
        {
            File.WriteAllText("game.cfg", "Counter-Strike 2,730\nDota 2,570\nNaraka: Bladepoint,1203220\nBattlefield: Bad Company 2,24960");
        }

        public List<GameList> LoadFromFile(string path)
        {
            List <GameList> GameList = new List<GameList>();

            if (!File.Exists(path))
            {
                MessageBox.Show("Creating Config", "First Time Run", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CreateDefaultConfig();
                return GameList;
            }

            using (var reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split(',');
                    if (parts.Length != 2)
                    {
                        MessageBox.Show("Error", $"Invalid line format in configuration file: {line}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    GameList.Add(new GameList() { Name = parts[0].Trim(), ID = parts[1].Trim() });
                }
                return GameList;
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<GameList> items = LoadFromFile("game.cfg");

            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";

            refresh.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                btnStart.Text = "Stop";

                var get_gameid = comboBox1.SelectedValue.ToString();
                Environment.SetEnvironmentVariable("SteamAppId", get_gameid, EnvironmentVariableTarget.Process);
                if (ConnectToSteam())
                {
                    SetWindowName(Convert.ToUInt32(get_gameid));
                    lb_status.Text = "Game is running..";
                    btnStart.Text = "Stop";
                }
            }
            else
            {
                btnStart.Text = "Start";
                ShutdownSteam();
            }
        }

        private void SetWindowName(uint appId)
        {
            var sb = new StringBuilder(60);
            _steamApps001.GetAppData(appId, "name", sb);

            string gameName = sb.ToString().Trim();
            frm = new Form1();
            frm.Text = string.IsNullOrWhiteSpace(gameName) ? "Unknown game" : GetUnicodeString(gameName);
        }

        private string GetUnicodeString(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            return Encoding.UTF8.GetString(bytes);
        }

        public void ShutdownSteam()
        {
            if (_steamClient012 != null)
            {
                _steamClient012.BShutdownIfAllPipesClosed();
                _steamClient012.ReleaseUser(pipe, user);
                _steamClient012.BReleaseSteamPipe(pipe);
                _steamApps001 = null;
                _steamClient012 = null;
            }

            Steamworks.Load(false);

            foreach (Form form in Application.OpenForms)
            {
                if (form.Visible == false)
                {
                    form.Dispose();
                }
            }

            if (frm != null)
            {
                frm.Text = "No Games";
                Environment.SetEnvironmentVariable("SteamAppId", "0", EnvironmentVariableTarget.Process);
                frm.Dispose();
            }
        }

        private bool ConnectToSteam()
        {
            if (!Steamworks.Load(true))
            {
                MessageBox.Show("Steamworks failed to load.");
                return false;
            }

            _steamClient012 = Steamworks.CreateInterface<ISteamClient012>();
            if (_steamClient012 == null)
            {
                MessageBox.Show("Failed to create Steam Client inferface.");
                return false;
            }

            pipe = _steamClient012.CreateSteamPipe();
            if (pipe == 0)
            {
                MessageBox.Show("Failed to create Steam pipe.");
                return false;
            }

            user = _steamClient012.ConnectToGlobalUser(pipe);
            if (user == 0)
            {
                MessageBox.Show("Failed to connect to Steam user. (No game in this Account!)");
                return false;
            }

            _steamApps001 = _steamClient012.GetISteamApps<ISteamApps001>(user, pipe);
            if (_steamApps001 == null)
            {
                MessageBox.Show("Failed to create Steam Apps inferface.");
                return false;
            }

            return true;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            List<GameList> items = LoadFromFile("game.cfg");

            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }
    }

    public class GameList
    {
        public GameList() { }

        public string ID { set; get; }
        public string Name { set; get; }
    }
}
