namespace Test
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.Bus = new System.Windows.Forms.PictureBox();
            this.Obstacle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BackgroundMap = new System.Windows.Forms.PictureBox();
            this.School = new System.Windows.Forms.PictureBox();
            this.Destination = new System.Windows.Forms.PictureBox();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.LabelScoreNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.School)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destination)).BeginInit();
            this.SuspendLayout();
            // 
            // Bus
            // 
            this.Bus.BackColor = System.Drawing.Color.Transparent;
            this.Bus.Image = global::Test.Properties.Resources.TopRightBus;
            this.Bus.Location = new System.Drawing.Point(886, 118);
            this.Bus.Name = "Bus";
            this.Bus.Size = new System.Drawing.Size(135, 47);
            this.Bus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bus.TabIndex = 4;
            this.Bus.TabStop = false;
            // 
            // Obstacle
            // 
            this.Obstacle.Image = global::Test.Properties.Resources.stone;
            this.Obstacle.Location = new System.Drawing.Point(741, 327);
            this.Obstacle.Name = "Obstacle";
            this.Obstacle.Size = new System.Drawing.Size(54, 50);
            this.Obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle.TabIndex = 5;
            this.Obstacle.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BackgroundMap
            // 
            this.BackgroundMap.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundMap.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundMap.Image")));
            this.BackgroundMap.Location = new System.Drawing.Point(0, 0);
            this.BackgroundMap.Name = "BackgroundMap";
            this.BackgroundMap.Size = new System.Drawing.Size(1033, 563);
            this.BackgroundMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundMap.TabIndex = 3;
            this.BackgroundMap.TabStop = false;
            // 
            // School
            // 
            this.School.Image = global::Test.Properties.Resources.school;
            this.School.Location = new System.Drawing.Point(813, 482);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(88, 81);
            this.School.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.School.TabIndex = 7;
            this.School.TabStop = false;
            // 
            // Destination
            // 
            this.Destination.Image = global::Test.Properties.Resources.tracking;
            this.Destination.Location = new System.Drawing.Point(834, 434);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(45, 42);
            this.Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Destination.TabIndex = 8;
            this.Destination.TabStop = false;
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelScore.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LabelScore.Location = new System.Drawing.Point(502, 0);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(56, 21);
            this.LabelScore.TabIndex = 9;
            this.LabelScore.Text = "Score:";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelUser.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LabelUser.Location = new System.Drawing.Point(92, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(99, 21);
            this.LabelUser.TabIndex = 10;
            this.LabelUser.Text = "User name: ";
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLevel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LabelLevel.Location = new System.Drawing.Point(409, 0);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(58, 21);
            this.LabelLevel.TabIndex = 11;
            this.LabelLevel.Text = "Level: ";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDuration.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LabelDuration.Location = new System.Drawing.Point(815, 0);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(86, 21);
            this.LabelDuration.TabIndex = 12;
            this.LabelDuration.Text = "Duration: ";
            // 
            // LabelScoreNumber
            // 
            this.LabelScoreNumber.AutoSize = true;
            this.LabelScoreNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelScoreNumber.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LabelScoreNumber.Location = new System.Drawing.Point(564, 0);
            this.LabelScoreNumber.Name = "LabelScoreNumber";
            this.LabelScoreNumber.Size = new System.Drawing.Size(19, 21);
            this.LabelScoreNumber.TabIndex = 13;
            this.LabelScoreNumber.Text = "0";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 563);
            this.Controls.Add(this.LabelScoreNumber);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.School);
            this.Controls.Add(this.Obstacle);
            this.Controls.Add(this.Bus);
            this.Controls.Add(this.BackgroundMap);
            this.Name = "Level1";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.School)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox Bus;
        private PictureBox Obstacle;
        private System.Windows.Forms.Timer timer1;
        private PictureBox BackgroundMap;
        private PictureBox School;
        private PictureBox Destination;
        private Label LabelScore;
        private Label LabelUser;
        private Label LabelLevel;
        private Label LabelDuration;
        private Label LabelScoreNumber;
    }
}