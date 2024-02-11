namespace Test
{
    partial class Level2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.GameMapTimer = new System.Windows.Forms.Timer(this.components);
            this.BackgroundMap = new System.Windows.Forms.PictureBox();
            this.Bus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).BeginInit();
            this.SuspendLayout();
            // 
            // GameMapTimer
            // 
            this.GameMapTimer.Enabled = true;
            this.GameMapTimer.Interval = 30;
            this.GameMapTimer.Tick += new System.EventHandler(this.GameMapTimer_Tick);
            // 
            // BackgroundMap
            // 
            this.BackgroundMap.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundMap.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundMap.Image")));
            this.BackgroundMap.Location = new System.Drawing.Point(0, 0);
            this.BackgroundMap.Name = "BackgroundMap";
            this.BackgroundMap.Size = new System.Drawing.Size(1049, 602);
            this.BackgroundMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundMap.TabIndex = 2;
            this.BackgroundMap.TabStop = false;
            // 
            // Bus
            // 
            this.Bus.BackColor = System.Drawing.Color.Transparent;
            this.Bus.Image = global::Test.Properties.Resources.TopRightBus;
            this.Bus.Location = new System.Drawing.Point(51, 130);
            this.Bus.Name = "Bus";
            this.Bus.Size = new System.Drawing.Size(162, 52);
            this.Bus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bus.TabIndex = 3;
            this.Bus.TabStop = false;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 602);
            this.ControlBox = false;
            this.Controls.Add(this.Bus);
            this.Controls.Add(this.BackgroundMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FrmGameMap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer GameMapTimer;
        private PictureBox BackgroundMap;
        private PictureBox Bus;
    }
}