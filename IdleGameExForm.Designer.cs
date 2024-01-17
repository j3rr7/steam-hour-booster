namespace SteamGameBooster
{
    partial class IdleGameExForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdleGameExForm));
            this.CtxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GamesListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartIdleBtn = new System.Windows.Forms.Button();
            this.AutoIdleCheckBox = new System.Windows.Forms.CheckBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.GamesComboBox = new System.Windows.Forms.ComboBox();
            this.AddGameBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.CtxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtxMenuStrip
            // 
            this.CtxMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.CtxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.CtxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CtxMenuStrip.Name = "CtxMenuStrip";
            this.CtxMenuStrip.Size = new System.Drawing.Size(314, 25);
            this.CtxMenuStrip.TabIndex = 0;
            this.CtxMenuStrip.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadToolStripMenuItem.Image")));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // GamesListBox
            // 
            this.GamesListBox.FormattingEnabled = true;
            this.GamesListBox.HorizontalScrollbar = true;
            this.GamesListBox.Items.AddRange(new object[] {
            "Test1",
            "Test2",
            "Test3",
            "Test4",
            "Test5"});
            this.GamesListBox.Location = new System.Drawing.Point(12, 37);
            this.GamesListBox.Name = "GamesListBox";
            this.GamesListBox.Size = new System.Drawing.Size(125, 124);
            this.GamesListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Games";
            // 
            // StartIdleBtn
            // 
            this.StartIdleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartIdleBtn.Location = new System.Drawing.Point(143, 81);
            this.StartIdleBtn.Name = "StartIdleBtn";
            this.StartIdleBtn.Size = new System.Drawing.Size(160, 35);
            this.StartIdleBtn.TabIndex = 4;
            this.StartIdleBtn.Text = "Start";
            this.StartIdleBtn.UseVisualStyleBackColor = true;
            this.StartIdleBtn.Click += new System.EventHandler(this.StartIdleBtn_Click);
            // 
            // AutoIdleCheckBox
            // 
            this.AutoIdleCheckBox.AutoSize = true;
            this.AutoIdleCheckBox.Location = new System.Drawing.Point(185, 122);
            this.AutoIdleCheckBox.Name = "AutoIdleCheckBox";
            this.AutoIdleCheckBox.Size = new System.Drawing.Size(76, 17);
            this.AutoIdleCheckBox.TabIndex = 5;
            this.AutoIdleCheckBox.Text = "Auto Idling";
            this.AutoIdleCheckBox.UseVisualStyleBackColor = true;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(182, 146);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(96, 13);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Waiting for query...";
            // 
            // GamesComboBox
            // 
            this.GamesComboBox.FormattingEnabled = true;
            this.GamesComboBox.Location = new System.Drawing.Point(155, 37);
            this.GamesComboBox.Name = "GamesComboBox";
            this.GamesComboBox.Size = new System.Drawing.Size(106, 21);
            this.GamesComboBox.TabIndex = 7;
            // 
            // AddGameBtn
            // 
            this.AddGameBtn.Location = new System.Drawing.Point(267, 37);
            this.AddGameBtn.Name = "AddGameBtn";
            this.AddGameBtn.Size = new System.Drawing.Size(36, 21);
            this.AddGameBtn.TabIndex = 8;
            this.AddGameBtn.Text = "Add";
            this.AddGameBtn.UseVisualStyleBackColor = true;
            this.AddGameBtn.Click += new System.EventHandler(this.AddGameBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.Location = new System.Drawing.Point(143, 142);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(22, 21);
            this.RefreshBtn.TabIndex = 9;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // IdleGameExForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 171);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.AddGameBtn);
            this.Controls.Add(this.GamesComboBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.AutoIdleCheckBox);
            this.Controls.Add(this.StartIdleBtn);
            this.Controls.Add(this.GamesListBox);
            this.Controls.Add(this.CtxMenuStrip);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.CtxMenuStrip;
            this.MaximumSize = new System.Drawing.Size(330, 210);
            this.MinimumSize = new System.Drawing.Size(330, 210);
            this.Name = "IdleGameExForm";
            this.Text = "Steam Game Idler (pre-alpha)";
            this.CtxMenuStrip.ResumeLayout(false);
            this.CtxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CtxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox GamesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartIdleBtn;
        private System.Windows.Forms.CheckBox AutoIdleCheckBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox GamesComboBox;
        private System.Windows.Forms.Button AddGameBtn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}