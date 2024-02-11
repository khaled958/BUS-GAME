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

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}