namespace Test
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BackgroundMap = new System.Windows.Forms.PictureBox();
            this.Destination = new System.Windows.Forms.PictureBox();
            this.School = new System.Windows.Forms.PictureBox();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.DurationTimer = new System.Windows.Forms.Timer(this.components);
            this.Bus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.School)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.GameMapTimer_Tick);
            // 
            // BackgroundMap
            // 
            this.BackgroundMap.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundMap.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundMap.Image")));
            this.BackgroundMap.Location = new System.Drawing.Point(0, 0);
            this.BackgroundMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackgroundMap.Name = "BackgroundMap";
            this.BackgroundMap.Size = new System.Drawing.Size(1181, 751);
            this.BackgroundMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundMap.TabIndex = 2;
            this.BackgroundMap.TabStop = false;
            // 
            // Destination
            // 
            this.Destination.Image = global::DemoStart.Properties.Resources.tracking;
            this.Destination.Location = new System.Drawing.Point(844, 487);
            this.Destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(51, 56);
            this.Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Destination.TabIndex = 11;
            this.Destination.TabStop = false;
            // 
            // School
            // 
            this.School.Image = global::DemoStart.Properties.Resources.school;
            this.School.Location = new System.Drawing.Point(727, 459);
            this.School.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(101, 108);
            this.School.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.School.TabIndex = 10;
            this.School.TabStop = false;
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LabelScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelScore.Location = new System.Drawing.Point(569, 0);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(97, 28);
            this.LabelScore.TabIndex = 17;
            this.LabelScore.Text = "Score:  --";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LabelDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelDuration.Location = new System.Drawing.Point(933, 0);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(150, 28);
            this.LabelDuration.TabIndex = 16;
            this.LabelDuration.Text = "Duration:  --:--";
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LabelLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelLevel.Location = new System.Drawing.Point(472, 0);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(72, 28);
            this.LabelLevel.TabIndex = 15;
            this.LabelLevel.Text = "Level: ";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LabelUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelUser.Location = new System.Drawing.Point(111, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(123, 28);
            this.LabelUser.TabIndex = 14;
            this.LabelUser.Text = "User name: ";
            // 
            // DurationTimer
            // 
            this.DurationTimer.Enabled = true;
            this.DurationTimer.Interval = 1000;
            this.DurationTimer.Tick += new System.EventHandler(this.DurationTimer_Tick);
            // 
            // Bus
            // 
            this.Bus.Image = global::DemoStart.Properties.Resources.TopRightBus;
            this.Bus.Location = new System.Drawing.Point(27, 0);
            this.Bus.Name = "Bus";
            this.Bus.Size = new System.Drawing.Size(135, 47);
            this.Bus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bus.TabIndex = 18;
            this.Bus.TabStop = false;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 751);
            this.ControlBox = false;
            this.Controls.Add(this.Bus);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.School);
            this.Controls.Add(this.BackgroundMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FrmGameMap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.School)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox BackgroundMap;
        private PictureBox Destination;
        private PictureBox School;
        private Label LabelScore;
        private Label LabelDuration;
        private Label LabelLevel;
        private Label LabelUser;
        private System.Windows.Forms.Timer DurationTimer;
        private PictureBox Bus;
    }
}