namespace DemoStart
{
    partial class History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridHistory2 = new System.Windows.Forms.DataGridView();
            this.BtnShowSteps = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProfileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            this.StepDataGrid = new System.Windows.Forms.DataGridView();
            this.StepCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridHistory2
            // 
            this.DataGridHistory2.AllowUserToAddRows = false;
            this.DataGridHistory2.AllowUserToDeleteRows = false;
            this.DataGridHistory2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridHistory2.BackgroundColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridHistory2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridHistory2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridHistory2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnShowSteps,
            this.ProfileColumn,
            this.DateColumn,
            this.DurationColumn,
            this.ScoreColumn,
            this.LevelsColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridHistory2.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridHistory2.Location = new System.Drawing.Point(45, 68);
            this.DataGridHistory2.Name = "DataGridHistory2";
            this.DataGridHistory2.ReadOnly = true;
            this.DataGridHistory2.RowHeadersWidth = 51;
            this.DataGridHistory2.RowTemplate.Height = 29;
            this.DataGridHistory2.Size = new System.Drawing.Size(700, 160);
            this.DataGridHistory2.TabIndex = 26;
            this.DataGridHistory2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridHistory2_CellClick_1);
            // 
            // BtnShowSteps
            // 
            this.BtnShowSteps.HeaderText = "Show Steps";
            this.BtnShowSteps.MinimumWidth = 6;
            this.BtnShowSteps.Name = "BtnShowSteps";
            this.BtnShowSteps.ReadOnly = true;
            // 
            // ProfileColumn
            // 
            this.ProfileColumn.HeaderText = "Profile";
            this.ProfileColumn.MinimumWidth = 6;
            this.ProfileColumn.Name = "ProfileColumn";
            this.ProfileColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.DateColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // DurationColumn
            // 
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.MinimumWidth = 6;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.ReadOnly = true;
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.HeaderText = "Score";
            this.ScoreColumn.MinimumWidth = 6;
            this.ScoreColumn.Name = "ScoreColumn";
            this.ScoreColumn.ReadOnly = true;
            // 
            // LevelsColumn
            // 
            this.LevelsColumn.HeaderText = "Levels";
            this.LevelsColumn.MinimumWidth = 6;
            this.LevelsColumn.Name = "LevelsColumn";
            this.LevelsColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "History";
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.StepLabel.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StepLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.StepLabel.Location = new System.Drawing.Point(45, 231);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(80, 30);
            this.StepLabel.TabIndex = 28;
            this.StepLabel.Text = "Steps";
            this.StepLabel.Visible = false;
            this.StepLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // StepDataGrid
            // 
            this.StepDataGrid.AllowUserToAddRows = false;
            this.StepDataGrid.AllowUserToDeleteRows = false;
            this.StepDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StepDataGrid.BackgroundColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StepDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.StepDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StepDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StepCol,
            this.Direction,
            this.DurationCol});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StepDataGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.StepDataGrid.Location = new System.Drawing.Point(45, 264);
            this.StepDataGrid.Name = "StepDataGrid";
            this.StepDataGrid.ReadOnly = true;
            this.StepDataGrid.RowHeadersWidth = 51;
            this.StepDataGrid.RowTemplate.Height = 29;
            this.StepDataGrid.Size = new System.Drawing.Size(700, 144);
            this.StepDataGrid.TabIndex = 29;
            this.StepDataGrid.Visible = false;
            this.StepDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StepDataGrid_CellClick);
            // 
            // StepCol
            // 
            this.StepCol.HeaderText = "Step";
            this.StepCol.MinimumWidth = 6;
            this.StepCol.Name = "StepCol";
            this.StepCol.ReadOnly = true;
            this.StepCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Direction
            // 
            this.Direction.HeaderText = "Direction";
            this.Direction.MinimumWidth = 6;
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            // 
            // DurationCol
            // 
            this.DurationCol.HeaderText = "Duration";
            this.DurationCol.MinimumWidth = 6;
            this.DurationCol.Name = "DurationCol";
            this.DurationCol.ReadOnly = true;
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnStart.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.ForeColor = System.Drawing.Color.LightGreen;
            this.BtnStart.Location = new System.Drawing.Point(349, 414);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(95, 37);
            this.BtnStart.TabIndex = 30;
            this.BtnStart.Text = "Back";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DemoStart.Properties.Resources.HistoryBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.StepDataGrid);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridHistory2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History2";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGridHistory2;
        private Label label1;
        private Label StepLabel;
        private DataGridView StepDataGrid;
        private DataGridViewButtonColumn BtnShowSteps;
        private DataGridViewTextBoxColumn ProfileColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn DurationColumn;
        private DataGridViewTextBoxColumn ScoreColumn;
        private DataGridViewTextBoxColumn LevelsColumn;
        private DataGridViewTextBoxColumn StepCol;
        private DataGridViewTextBoxColumn Direction;
        private DataGridViewTextBoxColumn DurationCol;
        private Button BtnStart;
    }
}