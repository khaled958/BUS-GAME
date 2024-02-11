using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoStart.Class;
using Test;

namespace DemoStart
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player selectedProfile = new Player();
            Test.Level1 level1 = new Test.Level1();

            for (int i = 0; i < DemoStart.StartPage.playerList.Count; i++)
            {
                if (DemoStart.StartPage.playerList[i].Name.Equals(ComboSelectProfile.SelectedItem.ToString()))
                {
                    selectedProfile = DemoStart.StartPage.playerList[i];
                    break;
                }
            }

            this.Hide();
            Test.Level1.player = selectedProfile;
            FrmInstructions formInstructions = new FrmInstructions();
            formInstructions.ShowDialog();
            level1.Show();
        }

        public void fillList()
        {
            ComboSelectProfile.Items.Clear();
            for (int i = 0; i < StartPage.playerList.Count; i++)
            {
                ComboSelectProfile.Items.Add(StartPage.playerList[i].Name);
            }
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            fillList();
            if (StartPage.playerList.Count == 0)
            {
                MessageBox.Show("No players yet !!");
                this.Close();
                StartPage SP = new StartPage();
                SP.Show();
            }
            else
            {
                ComboSelectProfile.Text = StartPage.playerList[0].Name;
            }
        }
    }
}
