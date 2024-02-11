namespace Test
{
    partial class Level2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.Bus = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BackgroundMap = new System.Windows.Forms.PictureBox();
            this.School = new System.Windows.Forms.PictureBox();
            this.Destination = new System.Windows.Forms.PictureBox();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.Obstacle = new System.Windows.Forms.Button();
            this.LabelScore = new System.Windows.Forms.Label();
            this.DurationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.School)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destination)).BeginInit();
            this.SuspendLayout();
            // 
            // Bus
            // 
            this.Bus.BackColor = System.Drawing.Color.Transparent;
            this.Bus.Image = global::DemoStart.Properties.Resources.TopRightBus;
            this.Bus.Location = new System.Drawing.Point(14, 572);
            this.Bus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bus.Name = "Bus";
            this.Bus.Size = new System.Drawing.Size(135, 47);
            this.Bus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bus.TabIndex = 4;
            this.Bus.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.BackgroundMap.TabIndex = 3;
            this.BackgroundMap.TabStop = false;
            // 
            // School
            // 
            this.School.Image = global::DemoStart.Properties.Resources.school;
            this.School.Location = new System.Drawing.Point(929, 643);
            this.School.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(101, 108);
            this.School.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.School.TabIndex = 7;
            this.School.TabStop = false;
            // 
            // Destination
            // 
            this.Destination.Image = global::DemoStart.Properties.Resources.tracking;
            this.Destination.Location = new System.Drawing.Point(953, 579);
            this.Destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(51, 56);
            this.Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Destination.TabIndex = 8;
            this.Destination.TabStop = false;
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.BackColor = System.Drawing.Color.Transparent;
            this.LabelUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelUser.Location = new System.Drawing.Point(105, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(123, 28);
            this.LabelUser.TabIndex = 10;
            this.LabelUser.Text = "User name: ";
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.BackColor = System.Drawing.Color.Transparent;
            this.LabelLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelLevel.Location = new System.Drawing.Point(467, 0);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(72, 28);
            this.LabelLevel.TabIndex = 11;
            this.LabelLevel.Text = "Level: ";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.BackColor = System.Drawing.Color.Transparent;
            this.LabelDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelDuration.Location = new System.Drawing.Point(929, 0);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(107, 28);
            this.LabelDuration.TabIndex = 12;
            this.LabelDuration.Text = "Duration: ";
            // 
            // Obstacle
            // 
            this.Obstacle.BackColor = System.Drawing.Color.Transparent;
            this.Obstacle.BackgroundImage = global::DemoStart.Properties.Resources.Rock;
            this.Obstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Obstacle.Enabled = false;
            this.Obstacle.FlatAppearance.BorderSize = 0;
            this.Obstacle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Obstacle.Location = new System.Drawing.Point(207, 157);
            this.Obstacle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Obstacle.Name = "Obstacle";
            this.Obstacle.Size = new System.Drawing.Size(62, 67);
            this.Obstacle.TabIndex = 14;
            this.Obstacle.UseVisualStyleBackColor = false;
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.Transparent;
            this.LabelScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelScore.Location = new System.Drawing.Point(561, 0);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(97, 28);
            this.LabelScore.TabIndex = 15;
            this.LabelScore.Text = "Score:  --";
            // 
            // DurationTimer
            // 
            this.DurationTimer.Enabled = true;
            this.DurationTimer.Interval = 1000;
            this.DurationTimer.Tick += new System.EventHandler(this.DurationTimer_Tick);
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 751);
            this.ControlBox = false;
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.Obstacle);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.School);
            this.Controls.Add(this.Bus);
            this.Controls.Add(this.BackgroundMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Level2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Level2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.School)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox Bus;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox BackgroundMap;
        private PictureBox School;
        private PictureBox Destination;
        private Label LabelUser;
        private Label LabelLevel;
        private Label LabelDuration;
        private Button Obstacle;
        private Label LabelScore;
        private System.Windows.Forms.Timer DurationTimer;
    }
}