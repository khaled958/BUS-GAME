namespace DemoStart
{
    partial class CurrentProfiles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnShow = new System.Windows.Forms.Button();
            this.TxtMood = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboProfile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.BtnShow);
            this.panel1.Controls.Add(this.TxtMood);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtGender);
            this.panel1.Controls.Add(this.TxtAge);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ComboProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(301, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 412);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnShow
            // 
            this.BtnShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnShow.Location = new System.Drawing.Point(291, 332);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(130, 40);
            this.BtnShow.TabIndex = 10;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtMood
            // 
            this.TxtMood.BackColor = System.Drawing.Color.Wheat;
            this.TxtMood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMood.Location = new System.Drawing.Point(431, 248);
            this.TxtMood.Multiline = true;
            this.TxtMood.Name = "TxtMood";
            this.TxtMood.Size = new System.Drawing.Size(95, 28);
            this.TxtMood.TabIndex = 10;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(110, 332);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(130, 40);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(328, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bus Color :";
            // 
            // TxtGender
            // 
            this.TxtGender.BackColor = System.Drawing.Color.Wheat;
            this.TxtGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGender.Location = new System.Drawing.Point(115, 249);
            this.TxtGender.Multiline = true;
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(91, 28);
            this.TxtGender.TabIndex = 8;
            // 
            // TxtAge
            // 
            this.TxtAge.BackColor = System.Drawing.Color.Wheat;
            this.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAge.Location = new System.Drawing.Point(384, 186);
            this.TxtAge.Multiline = true;
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(125, 28);
            this.TxtAge.TabIndex = 7;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.Wheat;
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.Location = new System.Drawing.Point(101, 185);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(221, 28);
            this.TxtName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(328, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose your profile:";
            // 
            // ComboProfile
            // 
            this.ComboProfile.FormattingEnabled = true;
            this.ComboProfile.Location = new System.Drawing.Point(269, 106);
            this.ComboProfile.Name = "ComboProfile";
            this.ComboProfile.Size = new System.Drawing.Size(227, 28);
            this.ComboProfile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Profiles";
            // 
            // CurrentProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DemoStart.Properties.Resources.cuteanimated_331;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1120, 683);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrentProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Profiles";
            this.Load += new System.EventHandler(this.CurrentProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private ComboBox ComboProfile;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnBack;
        private Button BtnShow;
        private TextBox TxtGender;
        private TextBox TxtAge;
        private TextBox TxtName;
        private TextBox TxtMood;
        private Label label6;
    }
}