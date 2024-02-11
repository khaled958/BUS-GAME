namespace Test
{
    partial class FrmInstructions
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
            this.picBoxInstructions = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInstructions)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxInstructions
            // 
            this.picBoxInstructions.BackColor = System.Drawing.Color.Transparent;
            this.picBoxInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxInstructions.Image = global::Test.Properties.Resources.GameInstructions;
            this.picBoxInstructions.Location = new System.Drawing.Point(0, 0);
            this.picBoxInstructions.Name = "picBoxInstructions";
            this.picBoxInstructions.Size = new System.Drawing.Size(1049, 602);
            this.picBoxInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInstructions.TabIndex = 6;
            this.picBoxInstructions.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ink Free", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(401, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 54);
            this.label3.TabIndex = 10;
            this.label3.Text = "And hava fun! ^^";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(158, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(489, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "2- Avoid the obstacles as you drive the bus!";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(158, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "1- Make the bus arrive to the school as fast as you can!";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(375, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game Instructions: -";
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlay.BackgroundImage = global::Test.Properties.Resources.PlayButton;
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlay.Location = new System.Drawing.Point(896, 377);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(141, 79);
            this.BtnPlay.TabIndex = 11;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // FrmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 602);
            this.ControlBox = false;
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxInstructions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInstructions";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormInstructions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInstructions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBoxInstructions;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button BtnPlay;
    }
}