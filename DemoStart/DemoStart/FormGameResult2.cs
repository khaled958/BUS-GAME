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
    public partial class FormGameResult2 : Form
    {
        public FormGameResult2()
        {
            InitializeComponent();            
        }

        private void BtnNextLevel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test.Level3 level3 = new Test.Level3();
            level3.Show();
        }

        private void BtnEndGame_Click(object sender, EventArgs e)
        {
            Close();
            Test.Level1.player.SetData();
            StartPage.history.Add(Test.Level1.history);
            StartPage sp = new StartPage();
            sp.Show();
        }
    }
}
