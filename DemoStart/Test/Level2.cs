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
    public partial class Level1 : Form
    {        
        enum ORIENTATION { Horizontal, Vertical };
        enum FACING_POSITION{ Right, Left, Up, Down };
        List<Tuple<int, int, int, int, int, int, Tuple<int, int>, Tuple<Enum, Enum>>> randomPositions = new();
        Random random = new Random();

        int speed = 10;
        bool right = false;
        bool left = false;
        bool up = false;
        bool down = false;

        public Level1()
        {
            InitializeComponent();
            BackgroundMap.Controls.Add(Bus);
            Bus.BackColor = Color.Transparent;

            BackgroundMap.Controls.Add(Obstacle);
            Obstacle.BackColor = Color.Transparent;

            BackgroundMap.Controls.Add(School);
            School.BackColor = Color.Transparent;

            BackgroundMap.Controls.Add(Destination);
            Destination.BackColor = Color.Transparent;

            BackgroundMap.Controls.Add(LabelScore);
            LabelScore.BackColor = Color.Transparent;

            BackgroundMap.Controls.Add(LabelDuration);
            LabelDuration.BackColor = Color.Transparent;

            BackgroundMap.Controls.Add(LabelUser);
            LabelUser.BackColor = Color.Transparent;

            BackgroundMap.Controls.Add(LabelLevel);
            LabelLevel.BackColor = Color.Transparent;

            BackgroundMap.Controls.Add(LabelScoreNumber);
            LabelScoreNumber.BackColor = Color.Transparent;

            PopulateRandomLocation();
            SetRandomLocation();
        }

        public void PopulateRandomLocation()
        {
            randomPositions.Add(new(12, 116, 337, 214, 813, 482, new(838, 418), new(ORIENTATION.Horizontal, FACING_POSITION.Right)));
            randomPositions.Add(new(886, 119, 553, 119, 92, 482, new(115, 423), new(ORIENTATION.Horizontal, FACING_POSITION.Left)));
            randomPositions.Add(new(898, 423, 741, 324, 409, 34, new(432, 121), new(ORIENTATION.Horizontal, FACING_POSITION.Left)));
            randomPositions.Add(new(0, 0, 741, 327, 813, 482, new(834, 434), new(ORIENTATION.Vertical, FACING_POSITION.Down)));
            randomPositions.Add(new(318, 516 - Bus.Height - 50, 334, 264, 409, 170, new(431, 122), new(ORIENTATION.Vertical, FACING_POSITION.Up)));
        }

        public void SetRandomLocation()
        {
            Tuple<int, int, int, int, int, int, Tuple<int, int>, Tuple<Enum, Enum>> t = randomPositions[random.Next(0, randomPositions.Count)];
            Bus.Left = t.Item1;
            Bus.Top = t.Item2;

            Obstacle.Left = t.Item3;
            Obstacle.Top = t.Item4;

            School.Left = t.Item5;
            School.Top = t.Item6;

            Destination.Left = t.Item7.Item1;
            Destination.Top = t.Item7.Item2;

            if (t.Rest.Item1.Equals(ORIENTATION.Horizontal))
            {
                Bus.Size = new Size(135, 47);
                Bus.Image = Properties.Resources.TopRightBus;
            }
            if (t.Rest.Item1.Equals(ORIENTATION.Vertical))
            {
                Bus.Size = new Size(47, 135);
                Bus.Image = Properties.Resources.TopDownBus;
            }

            if (t.Rest.Item2.Equals(FACING_POSITION.Right))
            {
                Bus.Image = Properties.Resources.TopRightBus;
            }
            if (t.Rest.Item2.Equals(FACING_POSITION.Left))
            {
                Bus.Image = Properties.Resources.TopLeftBus;
            }
            if (t.Rest.Item2.Equals(FACING_POSITION.Up))
            {
                Bus.Image = Properties.Resources.TopUpBus;
            }
            if (t.Rest.Item2.Equals(FACING_POSITION.Down))
            {
                Bus.Image = Properties.Resources.TopDownBus;
            }
        }

        private void Level1_KeyDown(object sender, KeyEventArgs e)
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

        private void Level1_KeyUp(object sender, KeyEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right && Bus.Left < ClientSize.Width - Bus.Width && (Bus.Location.Y >= ClientSize.Height * .19 && Bus.Location.Y <= (ClientSize.Height * .19) + 25
                || Bus.Location.Y >= ClientSize.Height * .74 && Bus.Location.Y <= ClientSize.Height * .74 + 20))
            {
                Bus.Left += speed;
                Bus.Image = Properties.Resources.TopRightBus;
                Bus.Size = new Size(135, 47);
            }
            if (left && Bus.Left > 0 && (Bus.Location.Y >= ClientSize.Height * .19 && Bus.Location.Y <= (ClientSize.Height * .19) + 25
                || Bus.Location.Y >= ClientSize.Height * .74 && Bus.Location.Y <= ClientSize.Height * .74 + 20))
            {
                Bus.Left -= speed;
                Bus.Image = Properties.Resources.TopLeftBus;
                Bus.Size = new Size(135, 47);
            }
            if (up && Bus.Top >= 0 && (Bus.Location.X >= -10 && Bus.Location.X <= 25 || Bus.Location.X >= ClientSize.Width * .30 && Bus.Location.X <= (ClientSize.Width * .30) + 40
                || Bus.Location.X >= ClientSize.Width * .70 && Bus.Location.X <= ClientSize.Width * .70 + 20))
            {
                Bus.Top -= speed;
                Bus.Image = Properties.Resources.TopUpBus;
                Bus.Size = new Size(47, 135);
            }
            if (down && Bus.Top < ClientSize.Height - Bus.Height && (Bus.Location.X >= -10 && Bus.Location.X <= 25 || Bus.Location.X >= ClientSize.Width * .30 && Bus.Location.X <= (ClientSize.Width * .30) + 40
                || Bus.Location.X >= ClientSize.Width * .70 && Bus.Location.X <= ClientSize.Width * .70 + 20))
            {
                Bus.Top += speed;
                Bus.Image = Properties.Resources.TopDownBus;
                Bus.Size = new Size(47, 135);
            }

            if (Bus.Bounds.IntersectsWith(Obstacle.Bounds) && right)
            {
                Bus.Left = Obstacle.Left - Bus.Width;
                Obstacle.Visible = false;
                
            }
        }
    }
}
