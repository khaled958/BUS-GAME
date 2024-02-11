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
    public partial class CurrentProfiles : Form
    {
        public CurrentProfiles()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void fillList()
        {
            ComboProfile.Items.Clear();
            for(int i=0;i<StartPage.playerList.Count;i++)
            {
                ComboProfile.Items.Add(StartPage.playerList[i].Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < StartPage.playerList.Count; i++)
            {
                if (ComboProfile.SelectedItem.ToString() == StartPage.playerList[i].Name)
                {
                    TxtName.Text = StartPage.playerList[i].Name;
                    TxtAge.Text = StartPage.playerList[i].Age.ToString() + " Years Old";
                    TxtGender.Text = StartPage.playerList[i].Gender.ToString();
                    TxtMood.Text = StartPage.playerList[i].Color.ToString();
                }
            }
        }

        private void CurrentProfile_Load(object sender, EventArgs e)
        {
            fillList();
            if (StartPage.playerList.Count == 0)
            {
                ErrorMessageProfile error = new ErrorMessageProfile();
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ShowDialog();
                this.Close();
                
            }
            else
            {
                ComboProfile.Text = StartPage.playerList[0].Name;
            }
        }
    }
}
