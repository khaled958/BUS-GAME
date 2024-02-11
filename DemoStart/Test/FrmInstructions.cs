using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class FrmInstructions : Form
    {
        public FrmInstructions()
        {
            InitializeComponent();

            picBoxInstructions.Controls.Add(label1);
            label1.BackColor = Color.Transparent;

            picBoxInstructions.Controls.Add(label2);
            label2.BackColor = Color.Transparent;

            picBoxInstructions.Controls.Add(label3);
            label3.BackColor = Color.Transparent;

            picBoxInstructions.Controls.Add(label4);
            label4.BackColor = Color.Transparent;
        }

        private void FormInstructions_Load(object sender, EventArgs e)
        {
            double formHeight = ClientSize.Height;
            double formWidth = ClientSize.Width;

            label2.Font = new Font("ink free", 18, FontStyle.Bold);
            label2.Top = ClientSize.Height / 3 - 60;
            label4.Font = new Font("ink free", 18, FontStyle.Bold);
            label4.Top = ClientSize.Height / 3;
            label3.Top = ClientSize.Height / 2 - 35;

            BtnPlay.Top = (int)(formHeight * 0.62);
            BtnPlay.Left = (int)formWidth - BtnPlay.Width - 10;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Close();            
        }
    }
}