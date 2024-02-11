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

namespace DemoStart
{
    public partial class NewProfile : Form
    {
        Player player;
        public NewProfile()
        {
            player = new Player();
            InitializeComponent();
        }

        private void NewProfile_Load(object sender, EventArgs e)
        {
            TxtName.Select();
            RadioMale.Checked = true;
            RadioYellow.Checked = true;
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            //WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
            //wmp.URL = "C:\\Users\\husam\\Downloads\\C#_Project(Zain's Statistics)\\C#_Project\\Final - Copy\\DemoStart - Copy\\DemoStart - Copy\\DemoStart\\DemoStart\\DemoStart\\Resources\\minecraft_click.mp3";

            if (TxtName.Text == null || TxtName.Text == "" || ComboAge.Text == "")
            {
                MessageBox.Show("Please Enter a valid Name and Age!");
            }
            else
            {
                player.Name = TxtName.Text;
                player.Age = Convert.ToInt32(ComboAge.SelectedItem.ToString());
                if (RadioMale.Checked)
                {
                    player.Gender = GENDER.Male;
                }
                else if (RadioFemale.Checked)
                {
                    player.Gender = GENDER.Female;
                }
                if (RadioYellow.Checked)
                {
                    player.Color = COLOR.Yellow;
                    player.DownBus = Properties.Resources.TopDownBus;
                    player.UpBus = Properties.Resources.TopUpBus;
                    player.LeftBus = Properties.Resources.TopLeftBus;
                    player.RightBus = Properties.Resources.TopRightBus;
                }
                else if (RadioRed.Checked)
                {
                    player.Color = COLOR.Red;
                    player.DownBus = Properties.Resources.RedDownBus;
                    player.UpBus = Properties.Resources.RedUpBus;
                    player.LeftBus = Properties.Resources.RedLeftBus;
                    player.RightBus = Properties.Resources.RedRightBus;
                }
                else if (RadioBlue.Checked)
                {
                    player.Color = COLOR.Blue;
                    player.DownBus = Properties.Resources.BlueDownBus;
                    player.UpBus = Properties.Resources.BlueUpBus;
                    player.LeftBus = Properties.Resources.BlueLeftBus;
                    player.RightBus = Properties.Resources.BlueRightBus;
                }
            }
            bool flag = true;
            foreach (Player a in StartPage.playerList)
            {
                if (player.Equals(a))
                {
                    MessageBox.Show("This account has recently existed!!");
                    flag = false;
                }
            }
            if (flag)
            {
                this.Hide();
                StartPage.playerList.Add(player);
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
