namespace DemoStart
{
    partial class FormGameResult3
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
            this.LabelUserResult = new System.Windows.Forms.Label();
            this.LabelDurationResult = new System.Windows.Forms.Label();
            this.LabelScoreResult = new System.Windows.Forms.Label();
            this.BtnNextLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUserResult
            // 
            this.LabelUserResult.AutoSize = true;
            this.LabelUserResult.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelUserResult.ForeColor = System.Drawing.Color.Black;
            this.LabelUserResult.Location = new System.Drawing.Point(14, 56);
            this.LabelUserResult.Name = "LabelUserResult";
            this.LabelUserResult.Size = new System.Drawing.Size(168, 29);
            this.LabelUserResult.TabIndex = 3;
            this.LabelUserResult.Text = "User Name: ";
            // 
            // LabelDurationResult
            // 
            this.LabelDurationResult.AutoSize = true;
            this.LabelDurationResult.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDurationResult.ForeColor = System.Drawing.Color.Black;
            this.LabelDurationResult.Location = new System.Drawing.Point(14, 127);
            this.LabelDurationResult.Name = "LabelDurationResult";
            this.LabelDurationResult.Size = new System.Drawing.Size(156, 29);
            this.LabelDurationResult.TabIndex = 4;
            this.LabelDurationResult.Text = "Duration: ";
            // 
            // LabelScoreResult
            // 
            this.LabelScoreResult.AutoSize = true;
            this.LabelScoreResult.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelScoreResult.ForeColor = System.Drawing.Color.Black;
            this.LabelScoreResult.Location = new System.Drawing.Point(14, 196);
            this.LabelScoreResult.Name = "LabelScoreResult";
            this.LabelScoreResult.Size = new System.Drawing.Size(187, 29);
            this.LabelScoreResult.TabIndex = 5;
            this.LabelScoreResult.Text = "Level Score: ";
            // 
            // BtnNextLevel
            // 
            this.BtnNextLevel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNextLevel.ForeColor = System.Drawing.Color.Crimson;
            this.BtnNextLevel.Location = new System.Drawing.Point(377, 281);
            this.BtnNextLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNextLevel.Name = "BtnNextLevel";
            this.BtnNextLevel.Size = new System.Drawing.Size(130, 71);
            this.BtnNextLevel.TabIndex = 6;
            this.BtnNextLevel.Text = "Finish";
            this.BtnNextLevel.UseVisualStyleBackColor = true;
            this.BtnNextLevel.Click += new System.EventHandler(this.BtnNextLevel_Click);
            // 
            // FormGameResult3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 368);
            this.ControlBox = false;
            this.Controls.Add(this.BtnNextLevel);
            this.Controls.Add(this.LabelScoreResult);
            this.Controls.Add(this.LabelDurationResult);
            this.Controls.Add(this.LabelUserResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGameResult3";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 3 Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label LabelUserResult;
        public Label LabelDurationResult;
        public Label LabelScoreResult;
        public Button BtnNextLevel;
    }
}