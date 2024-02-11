namespace Test
{
    partial class Level3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level3));
            this.BackgroundMap = new System.Windows.Forms.PictureBox();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.Obstacle1 = new System.Windows.Forms.Button();
            this.Destination = new System.Windows.Forms.PictureBox();
            this.School = new System.Windows.Forms.PictureBox();
            this.Bus = new System.Windows.Forms.PictureBox();
            this.Obstacle2 = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.DurationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.School)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).BeginInit();
            this.SuspendLayout();
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
            this.BackgroundMap.TabIndex = 4;
            this.BackgroundMap.TabStop = false;
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelScore.Location = new System.Drawing.Point(560, 0);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(97, 28);
            this.LabelScore.TabIndex = 19;
            this.LabelScore.Text = "Score:  --";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelDuration.Location = new System.Drawing.Point(928, 0);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(107, 28);
            this.LabelDuration.TabIndex = 18;
            this.LabelDuration.Text = "Duration: ";
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelLevel.Location = new System.Drawing.Point(466, 0);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(72, 28);
            this.LabelLevel.TabIndex = 17;
            this.LabelLevel.Text = "Level: ";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelUser.Location = new System.Drawing.Point(104, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(123, 28);
            this.LabelUser.TabIndex = 16;
            this.LabelUser.Text = "User name: ";
            // 
            // Obstacle1
            // 
            this.Obstacle1.BackColor = System.Drawing.Color.Transparent;
            this.Obstacle1.BackgroundImage = global::DemoStart.Properties.Resources.Rock;
            this.Obstacle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Obstacle1.Enabled = false;
            this.Obstacle1.FlatAppearance.BorderSize = 0;
            this.Obstacle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Obstacle1.Location = new System.Drawing.Point(608, 568);
            this.Obstacle1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Obstacle1.Name = "Obstacle1";
            this.Obstacle1.Size = new System.Drawing.Size(62, 67);
            this.Obstacle1.TabIndex = 23;
            this.Obstacle1.UseVisualStyleBackColor = false;
            // 
            // Destination
            // 
            this.Destination.Image = global::DemoStart.Properties.Resources.tracking;
            this.Destination.Location = new System.Drawing.Point(1105, 568);
            this.Destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(51, 56);
            this.Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Destination.TabIndex = 22;
            this.Destination.TabStop = false;
            // 
            // School
            // 
            this.School.Image = global::DemoStart.Properties.Resources.school;
            this.School.Location = new System.Drawing.Point(1080, 643);
            this.School.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(101, 108);
            this.School.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.School.TabIndex = 21;
            this.School.TabStop = false;
            // 
            // Bus
            // 
            this.Bus.BackColor = System.Drawing.Color.Transparent;
            this.Bus.Image = global::DemoStart.Properties.Resources.TopRightBus;
            this.Bus.Location = new System.Drawing.Point(0, 159);
            this.Bus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bus.Name = "Bus";
            this.Bus.Size = new System.Drawing.Size(135, 47);
            this.Bus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bus.TabIndex = 20;
            this.Bus.TabStop = false;
            // 
            // Obstacle2
            // 
            this.Obstacle2.BackColor = System.Drawing.Color.Transparent;
            this.Obstacle2.BackgroundImage = global::DemoStart.Properties.Resources.Rock;
            this.Obstacle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Obstacle2.Enabled = false;
            this.Obstacle2.FlatAppearance.BorderSize = 0;
            this.Obstacle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Obstacle2.Location = new System.Drawing.Point(608, 159);
            this.Obstacle2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Obstacle2.Name = "Obstacle2";
            this.Obstacle2.Size = new System.Drawing.Size(62, 67);
            this.Obstacle2.TabIndex = 24;
            this.Obstacle2.UseVisualStyleBackColor = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // DurationTimer
            // 
            this.DurationTimer.Enabled = true;
            this.DurationTimer.Interval = 1000;
            this.DurationTimer.Tick += new System.EventHandler(this.DurationTimer_Tick);
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 751);
            this.ControlBox = false;
            this.Controls.Add(this.Obstacle2);
            this.Controls.Add(this.Obstacle1);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.School);
            this.Controls.Add(this.Bus);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.BackgroundMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Level3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Level3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.School)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox BackgroundMap;
        private Label LabelScore;
        private Label LabelDuration;
        private Label LabelLevel;
        private Label LabelUser;
        private Button Obstacle1;
        private PictureBox Destination;
        private PictureBox School;
        private PictureBox Bus;
        private Button Obstacle2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer DurationTimer;
    }
}