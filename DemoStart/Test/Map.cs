using System.Media;

namespace Test
{
    public partial class Level2 : Form
    {
        public Level2()
        {
            
            InitializeComponent();
            //PlayBusSound();
            BackgroundMap.Controls.Add(Bus);
            Bus.Location = new Point(0, 0);
            Bus.BackColor = Color.Transparent;
        }

        WMPLib.WindowsMediaPlayer wmp1 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wmp2 = new WMPLib.WindowsMediaPlayer();

        int speed = 10;
        bool right = false;
        bool left = false;
        bool up = false;
        bool down = false;

        public void PlayBusSound()
        {
            wmp1.URL = @"C:\\Users\husam\Downloads\\bus-engine-sound.mp3";
            wmp1.settings.setMode("loop", true);            
            wmp1.controls.play();
        }

        public void PlayClickSound()
        {
            wmp2.URL = @"C:\\Users\husam\Downloads\Test\Test\Resources\\minecraft_click.mp3";
            wmp2.controls.play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                right = true;
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                left = true;
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                up = true;
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                down = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                right = false;
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                left = false;
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                up = false;
            }

            if (e.KeyCode.Equals(Keys.Down))
            {
                down = false;
            }
        }

        private void GameMapTimer_Tick(object sender, EventArgs e)
        {
            if (right && Bus.Left < ClientSize.Width - Bus.Width && (Bus.Location.Y >= ClientSize.Height * .19 && Bus.Location.Y <= (ClientSize.Height * .19) + 25
                || Bus.Location.Y >= ClientSize.Height * .74 && Bus.Location.Y <= ClientSize.Height * .74 + 20))
            {
                Bus.Left += speed;
                Bus.Image = Properties.Resources.TopRightBus;
                Bus.Size = new Size(162, 52);
            }
            if (left && Bus.Left > 0 && (Bus.Location.Y >= ClientSize.Height * .19 && Bus.Location.Y <= (ClientSize.Height * .19) + 25
                || Bus.Location.Y >= ClientSize.Height * .74 && Bus.Location.Y <= ClientSize.Height * .74 + 20))
            {
                Bus.Left -= speed;
                Bus.Image = Properties.Resources.TopLeftBus;
                Bus.Size = new Size(162, 52);
            }
            if (up && Bus.Top >= 0 && (Bus.Location.X >= -10 && Bus.Location.X <= 25 || Bus.Location.X >= ClientSize.Width * .30 && Bus.Location.X <= (ClientSize.Width * .30) + 40
                || Bus.Location.X >= ClientSize.Width * .70 && Bus.Location.X <= ClientSize.Width * .70 + 20))
            {
                Bus.Top -= speed;
                Bus.Image = Properties.Resources.TopUpBus;
                Bus.Size = new Size(56, 150);
            }
            if (down && Bus.Top < ClientSize.Height - Bus.Height && (Bus.Location.X >= -10 && Bus.Location.X <= 25 || Bus.Location.X >= ClientSize.Width * .30 && Bus.Location.X <= (ClientSize.Width * .30) + 40
                || Bus.Location.X >= ClientSize.Width * .70 && Bus.Location.X <= ClientSize.Width * .70 + 20))
            {
                Bus.Top += speed;
                Bus.Image = Properties.Resources.TopDownBus;
                Bus.Size = new Size(56, 150);
            }
        }


        private void FrmGameMap_Load(object sender, EventArgs e)
        {
            FrmInstructions formInstructions = new FrmInstructions();
            formInstructions.StartPosition = FormStartPosition.CenterScreen;
            formInstructions.Size = Size;
            formInstructions.ShowDialog();
        }
    }
}  