// Icons By Icons8
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamGameBooster
{
    public partial class IdleGameExForm : Form
    {
        private bool isRunning = false;

        public IdleGameExForm()
        {
            InitializeComponent();

            // this.KeyPreview = true;
        }

        #region Events
        private void StartIdleBtn_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                StartIdleBtn.Text = "Stop";
            }
            else
            {
                StartIdleBtn.Text = "Start";
            }
        }

        private void AddGameBtn_Click(object sender, EventArgs e)
        {
            var idx = GamesComboBox.FindStringExact(GamesComboBox.Text);
            if (idx != -1)
            {
                GamesComboBox.SelectedIndex = idx;
            }
            else
            {

            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.Menu))
            {
                CtxMenuStrip.Visible = !CtxMenuStrip.Visible;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
