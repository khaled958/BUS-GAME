using DemoStart;
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
    public partial class FormGameResult1 : Form
    {
        public FormGameResult1()
        {
            InitializeComponent();
        }

        private void BtnNextLevel_Click(object sender, EventArgs e)
        {            
            this.Hide();
            Test.Level2 level2 = new Level2();
            level2.Show();
        }

        private void BtnEndGame_Click(object sender, EventArgs e)
        {
            Close();
            Test.Level1.player.SetData();
            StartPage.history.Add(Level1.history);
            StartPage sp = new StartPage();
            sp.Show();
        }
    }
}
