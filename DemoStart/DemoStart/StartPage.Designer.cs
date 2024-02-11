namespace DemoStart
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.xxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuStripGame = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StartBus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartBus)).BeginInit();
            this.SuspendLayout();
            // 
            // xxToolStripMenuItem
            // 
            this.xxToolStripMenuItem.Name = "xxToolStripMenuItem";
            this.xxToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.xxToolStripMenuItem.Text = "xx";
            // 
            // ddToolStripMenuItem
            // 
            this.ddToolStripMenuItem.Name = "ddToolStripMenuItem";
            this.ddToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.ddToolStripMenuItem.Text = "dd";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.fToolStripMenuItem.Text = "f";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.hToolStripMenuItem.Text = "h";
            // 
            // StartScreenTimer
            // 
            this.StartScreenTimer.Enabled = true;
            this.StartScreenTimer.Interval = 60;
            this.StartScreenTimer.Tick += new System.EventHandler(this.StartScreenTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DemoStart.Properties.Resources.ss;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1184, 788);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripGame,
            this.MenuStripAccount,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.MainMenu.Location = new System.Drawing.Point(365, 9);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.MainMenu.Size = new System.Drawing.Size(583, 63);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "MainMenu";
            // 
            // MenuStripGame
            // 
            this.MenuStripGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.MenuStripGame.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MenuStripGame.Name = "MenuStripGame";
            this.MenuStripGame.Size = new System.Drawing.Size(98, 39);
            this.MenuStripGame.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newGameToolStripMenuItem.Image = global::DemoStart.Properties.Resources.play;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(234, 36);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click_1);
            // 
            // MenuStripAccount
            // 
            this.MenuStripAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.currentProfileToolStripMenuItem});
            this.MenuStripAccount.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MenuStripAccount.Name = "MenuStripAccount";
            this.MenuStripAccount.Size = new System.Drawing.Size(128, 39);
            this.MenuStripAccount.Text = "Account";
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.newProfileToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newProfileToolStripMenuItem.Image = global::DemoStart.Properties.Resources.user_add;
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.newProfileToolStripMenuItem.Text = "New Profile";
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click_1);
            // 
            // currentProfileToolStripMenuItem
            // 
            this.currentProfileToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.currentProfileToolStripMenuItem.Image = global::DemoStart.Properties.Resources.users;
            this.currentProfileToolStripMenuItem.Name = "currentProfileToolStripMenuItem";
            this.currentProfileToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.currentProfileToolStripMenuItem.Text = "Current Profiles";
            this.currentProfileToolStripMenuItem.Click += new System.EventHandler(this.currentProfileToolStripMenuItem_Click_1);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.playBackToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.statisticsToolStripMenuItem.Image = global::DemoStart.Properties.Resources.statistics;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(234, 36);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.historyToolStripMenuItem.Image = global::DemoStart.Properties.Resources.history;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(234, 36);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // playBackToolStripMenuItem
            // 
            this.playBackToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.playBackToolStripMenuItem.Image = global::DemoStart.Properties.Resources.multimedia;
            this.playBackToolStripMenuItem.Name = "playBackToolStripMenuItem";
            this.playBackToolStripMenuItem.Size = new System.Drawing.Size(234, 36);
            this.playBackToolStripMenuItem.Text = "Play Back";
            this.playBackToolStripMenuItem.Click += new System.EventHandler(this.playBackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(74, 39);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // StartBus
            // 
            this.StartBus.BackColor = System.Drawing.Color.Transparent;
            this.StartBus.Image = global::DemoStart.Properties.Resources.StartPageBus;
            this.StartBus.Location = new System.Drawing.Point(101, 523);
            this.StartBus.Name = "StartBus";
            this.StartBus.Size = new System.Drawing.Size(454, 200);
            this.StartBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartBus.TabIndex = 3;
            this.StartBus.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 788);
            this.ControlBox = false;
            this.Controls.Add(this.StartBus);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem xxToolStripMenuItem;
        private ToolStripMenuItem ddToolStripMenuItem;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.Timer StartScreenTimer;
        private PictureBox pictureBox1;
        private MenuStrip MainMenu;
        private ToolStripMenuItem MenuStripGame;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem MenuStripAccount;
        private ToolStripMenuItem newProfileToolStripMenuItem;
        private ToolStripMenuItem currentProfileToolStripMenuItem;
        private PictureBox StartBus;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem playBackToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}