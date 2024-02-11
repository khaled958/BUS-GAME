using DemoStart;
using DemoStart.Class;
using DemoStart.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Test
{
    public partial class Level2 : Form
    {
        Game game = new Game();
        Player player = new Player();
        public HistoryClass history = new HistoryClass();

        enum ORIENTATION { Horizontal, Vertical };
        enum FACING_POSITION{ Right, Left, Up, Down };
        List<Tuple<int, int, int, int, int, int, Tuple<int, int>, Tuple<Enum, Enum>>> randomPositions = new();
        Random random = new Random();

        int speed = 10;
        bool right = false;
        bool left = false;
        bool up = false;
        bool down = false;

        bool Hisup = true;
        bool Hisdown = true;
        bool Hisright = true;
        bool Hisleft = true;

        int dt = 0;
        int score = 20;
        int duration = 0;
        int minutes = 0;
        int level = 2;
        int id;

        public Level2()
        {
            InitializeComponent();
            BackgroundMap.Controls.Add(Bus);
            Bus.BackColor = Color.Transparent;
            Bus.Image = Level1.player.LeftBus;

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

            LabelUser.Text = $"User name: {Test.Level1.player.Name}";
            LabelLevel.Text = "Level: 2";

        }

        public void PopulateRandomLocations()
        {
            randomPositions.Add(new(0, 160, 613, 158, 926, 643, new(952, 565), new(ORIENTATION.Horizontal, FACING_POSITION.Right)));
            randomPositions.Add(new(864, 0, 383, 373, 104, 457, new(33, 482), new(ORIENTATION.Vertical, FACING_POSITION.Down)));
            randomPositions.Add(new(844, ClientSize.Height - Bus.Width, 848, 342, 260, 47, new(367, 80), new(ORIENTATION.Vertical, FACING_POSITION.Up)));
            randomPositions.Add(new(1046, 167, 387, 568, 262, 643, new(292, 570), new(ORIENTATION.Horizontal, FACING_POSITION.Left)));
            randomPositions.Add(new(23, 0, 207, 157, 727, 459, new(844, 487), new(ORIENTATION.Vertical, FACING_POSITION.Down)));
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
                Bus.Image = Level1.player.RightBus;
            }
            if (t.Rest.Item1.Equals(ORIENTATION.Vertical))
            {
                Bus.Size = new Size(47, 135);
                Bus.Image = Level1.player.DownBus;
            }

            if (t.Rest.Item2.Equals(FACING_POSITION.Right))
            {
                Bus.Image = Level1.player.RightBus;
            }
            if (t.Rest.Item2.Equals(FACING_POSITION.Left))
            {
                Bus.Image = Level1.player.LeftBus;
            }
            if (t.Rest.Item2.Equals(FACING_POSITION.Up))
            {
                Bus.Image = Level1.player.UpBus;
            }
            if (t.Rest.Item2.Equals(FACING_POSITION.Down))
            {
                Bus.Image = Level1.player.DownBus;
            }
        }

        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                right = true;
                if (Hisright)
                {
                    Test.Level1.history.Steps.Add(new("Right", duration));
                    Hisright = false;
                }
                Hisup = true;
                Hisdown = true;
                Hisleft = true;
            }

            else if (e.KeyCode.Equals(Keys.Left))
            {
                left = true;
                if (Hisleft)
                {
                    Test.Level1.history.Steps.Add(new("Left", duration));
                    Hisleft = false;
                }
                Hisup = true;
                Hisdown = true;
                Hisright = true;
            }
            else if (e.KeyCode.Equals(Keys.Up))
            {
                up = true;
                if (Hisup)
                {
                    Test.Level1.history.Steps.Add(new("Up", duration));
                    Hisup = false;
                }
                Hisright = true;
                Hisdown = true;
                Hisleft = true;
            }
            else if (e.KeyCode.Equals(Keys.Down))
            {
                down = true;
                if (Hisdown)
                {
                   Test.Level1.history.Steps.Add(new("Down", duration));
                    Hisdown = false;
                }
                Hisup = true;
                Hisright = true;
                Hisleft = true;
            }
        }

        private void Level1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                right = false;
            }
            else if (e.KeyCode.Equals(Keys.Left))
            {
                left = false;
            }
            else if (e.KeyCode.Equals(Keys.Up))
            {
                up = false;
            }
            else if(e.KeyCode.Equals(Keys.Down))
            {
                down = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right && Bus.Left < ClientSize.Width - Bus.Width && (Bus.Location.Y >= 160 && Bus.Location.Y <= 170
                || Bus.Location.Y >= 572 && Bus.Location.Y <= 582))
            {
                Bus.Left += speed;
                Bus.Image = Level1.player.RightBus;
                Bus.Size = new Size(135, 47);
            }
            if (left && Bus.Left > 0 && (Bus.Location.Y >= 160 && Bus.Location.Y <= 170
                || Bus.Location.Y >= 572 && Bus.Location.Y <= 582))
            {
                Bus.Left -= speed;
                Bus.Image = Level1.player.LeftBus;
                Bus.Size = new Size(135, 47);
            }
            if (up && Bus.Top >= 0 && (Bus.Location.X >= 23 && Bus.Location.X <= 45 || Bus.Location.X >= 384 && Bus.Location.X <= 405
                || Bus.Location.X >= 844 && Bus.Location.X <= 865))
            {
                Bus.Top -= speed;
                Bus.Image = Level1.player.UpBus;
                Bus.Size = new Size(47, 135);
            }
            if (down && Bus.Top < ClientSize.Height - Bus.Height && (Bus.Location.X >= 23 && Bus.Location.X <= 45 || Bus.Location.X >= 384 && Bus.Location.X <= 405
                || Bus.Location.X >= 844 && Bus.Location.X <= 865))
            {
                Bus.Top += speed;
                Bus.Image = Level1.player.DownBus;
                Bus.Size = new Size(47, 135);
            }

            if (Bus.Bounds.IntersectsWith(Obstacle.Bounds))
            {
                Obstacle.Location = new Point(99999, 99999);
                Test.Level1.player.gameList[Test.Level1.player.gameList.Count - 1].Score -= 5;

                if (Test.Level1.player.gameList[Test.Level1.player.gameList.Count - 1].Score < 0)
                {
                    Test.Level1.player.gameList[Test.Level1.player.gameList.Count - 1].Score = 0;
                }
            }

            if (Bus.Bounds.IntersectsWith(Destination.Bounds))
            {
                Destination.Visible = false;
                LabelScore.Text = "Score: " + Test.Level1.player.gameList[Test.Level1.player.gameList.Count - 1].Score.ToString() + " + " + score.ToString();
                Test.Level1.player.gameList[Test.Level1.player.gameList.Count - 1].Score += score;
                EndLevel();
            }

            LabelScore.Text = "Score: " + Test.Level1.player.gameList[Test.Level1.player.gameList.Count - 1].Score.ToString();
        }

        private void DurationTimer_Tick(object sender, EventArgs e)
        {
            duration++;
            if (duration > 59)
            {
                duration = 0;
                minutes++;
            }
            if (duration < 10 && minutes < 10)
                LabelDuration.Text = $"Duration: 0{minutes}:0{duration}";
            else if (duration < 10)
                LabelDuration.Text = $"Duration: {minutes}:0{duration}";
            else if (minutes < 10)
                LabelDuration.Text = $"Duration: 0{minutes}:{duration}";

        }

        public void SaveGameData()
        {
            dt = duration + (minutes * 60);
            Level1.player.gameList[Level1.player.gameList.Count - 1].Duration += dt;
            Level1.player.gameList[Level1.player.gameList.Count - 1].Date = DateTime.Now;
            Level1.player.gameList[Level1.player.gameList.Count - 1].Level = level;
            Level1.player.gameList[Level1.player.gameList.Count - 1].PlayerName = player.Name;

        }

        public void EndLevel()
        {
            GameTimer.Stop();
            DurationTimer.Stop();
            SaveGameData();

            FormGameResult2 formGameResult = new FormGameResult2();
            formGameResult.LabelDurationResult.Text += PrintDuration();
            formGameResult.LabelUserResult.Text += Test.Level1.player.Name;
            formGameResult.LabelScoreResult.Text += Test.Level1.player.gameList[Test.Level1.player.gameList.Count - 1].Score;
            formGameResult.ShowDialog();
            this.Close();
        }
        public string PrintDuration()
        {
            duration = dt % 60;
            minutes = dt / 60;
            if (duration < 10 && minutes < 10)
                return $"Duration: 0{minutes}:0{duration}";
            else if (duration < 10)
                return $"Duration: {minutes}:0{duration}";
            else if (minutes < 10)
                return $"Duration: 0{minutes}:{duration}";
            else
                return $"Duration: {minutes}:{duration}";
        }

        private void Level2_Load(object sender, EventArgs e)
        {

            PopulateRandomLocations();
            SetRandomLocation();
        }
    }
}