using DemoStart.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoStart
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            InsertData();
        }

        public void InsertData()
        {
            foreach (Player p in StartPage.playerList)
            {
                foreach (Game g in p.gameList)
                {
                    DataGridHistory2.Rows.Add("Show Steps",
                        p.Name,
                        g.Date.ToShortDateString(),
                        g.Duration,
                        g.Score,
                        g.Level);
                    //DataGridHistory2.
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridHistory2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StepDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridHistory2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = DataGridHistory2.CurrentCell.RowIndex;
            if (StepDataGrid.Visible == true)
            {
                StepDataGrid.Rows.Clear();
                StepDataGrid.Visible = false;
                StepLabel.Visible = false;
            }
            else
            {
                StepDataGrid.Rows.Clear();
                StepDataGrid.Visible = true;
                StepLabel.Visible = true;
                for (int i = 0; i < StartPage.history[row].Steps.Count; i++)
                {
                    if (i == 0)
                        StepDataGrid.Rows.Add((i + 1), StartPage.history[row].Steps[i].Item1, StartPage.history[row].Steps[i].Item2);
                    else
                    {
                        int ans = Math.Abs(StartPage.history[row].Steps[i].Item2 - StartPage.history[row].Steps[i - 1].Item2);
                        if(ans > 0)
                            StepDataGrid.Rows.Add((i + 1), StartPage.history[row].Steps[i].Item1, ans);
                        else
                            StepDataGrid.Rows.Add((i + 1), StartPage.history[row].Steps[i].Item1, " < 1");
                    }
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
