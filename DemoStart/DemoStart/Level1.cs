using DemoStart;
using DemoStart.Class;
using DemoStart.Classes;

namespace Test
{
    public partial class Level1 : Form
    {
        public Game game = new Game();
        public static Player player = new Player();
        public static HistoryClass history = new HistoryClass();
        enum ORIENTATION { Horizontal, Vertical };
        enum FACING_POSITION { Right, Left, Up, Down };
        List<Tuple<int, int, int, int, int, int, Tuple<Enum, Enum>>> randomPositions = new();
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

        /*int rightCount = 1;
        int leftCount = 1;
        int upCount = 1;
        int downCount = 1;

        int stepsCounter = 1;

        int counter = 0;*/

        int dt = 0;
        int score = 0;
        int duration = 0;
        int minutes = 0;
        int level = 1;
        int id = 0;

        public Level1()
        {            
            InitializeComponent();


            id++;

            history = new HistoryClass();

            BackgroundMap.Controls.Add(Bus);
            Bus.BackColor = Color.Transparent;
            Bus.Image = player.LeftBus;

            BackgroundMap.Controls.Add(School);
            School.BackColor = Color.Transparent;

            BackgroundMap.Controls.Add(Destination);
            Destination.BackColor = Color.Transparent;

            LabelScore.Text = "Score: " + game.Score;
            
        }

        public void PopulateRandomLocations()
        {
            randomPositions.Add(new(0, 160, 926, 643, 952, 565, new(ORIENTATION.Horizontal, FACING_POSITION.Right)));
            randomPositions.Add(new(864, 0, 104, 457, 33, 482, new(ORIENTATION.Vertical, FACING_POSITION.Down)));
            randomPositions.Add(new(844, ClientSize.Height - Bus.Width, 260, 47, 367, 74, new(ORIENTATION.Vertical, FACING_POSITION.Up)));
            randomPositions.Add(new(1046, 167, 262, 643, 292, 570, new(ORIENTATION.Horizontal, FACING_POSITION.Left)));
            randomPositions.Add(new(23, 0, 727, 459, 844, 487, new(ORIENTATION.Vertical, FACING_POSITION.Down)));
        }

        public void SetRandomLocation()
        {
            Tuple<int, int, int, int, int, int, Tuple<Enum, Enum>> t = randomPositions[random.Next(0, randomPositions.Count)];
            Bus.Image = player.LeftBus;
            Bus.Left = t.Item1;
            Bus.Top = t.Item2;

            School.Left = t.Item3;
            School.Top = t.Item4;

            Destination.Left = t.Item5;
            Destination.Top = t.Item6;

            if (t.Item7.Item1.Equals(ORIENTATION.Horizontal))
            {
                Bus.Size = new Size(135, 47);
                Bus.Image = player.RightBus;
            }
            if (t.Item7.Item1.Equals(ORIENTATION.Vertical))
            {
                Bus.Size = new Size(47, 135);
                Bus.Image = player.DownBus;
            }

            if (t.Item7.Item2.Equals(FACING_POSITION.Right))
            {
                Bus.Image = player.RightBus;
            }
            if (t.Item7.Item2.Equals(FACING_POSITION.Left))
            {
                Bus.Image = player.LeftBus;
            }
            if (t.Item7.Item2.Equals(FACING_POSITION.Up))
            {
                Bus.Image = player.UpBus;
            }
            if (t.Item7.Item2.Equals(FACING_POSITION.Down))
            {
                Bus.Image = player.DownBus;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MovementRecord mr = new MovementRecord();
            if (e.KeyCode.Equals(Keys.Right))
            {
                right = true;
                if (Hisright)
                {
                    history.Steps.Add(new("Right", duration));
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
                    history.Steps.Add(new("Left", duration));
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
                    history.Steps.Add(new("Up", duration));
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
                    history.Steps.Add(new("Down", duration));
                    Hisdown = false;
                }
                Hisup = true;
                Hisright = true;
                Hisleft = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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
            else if (e.KeyCode.Equals(Keys.Down))
            {
                down = false;
            }
        }

        private void GameMapTimer_Tick(object sender, EventArgs e)
        {
            if (right && Bus.Left < ClientSize.Width - Bus.Width && (Bus.Location.Y >= 160 && Bus.Location.Y <= 170
                || Bus.Location.Y >= 572 && Bus.Location.Y <= 582))
            {
                Bus.Left += speed;
                Bus.Image = player.RightBus;
                Bus.Size = new Size(135, 47);
            }
            if (left && Bus.Left > 0 && (Bus.Location.Y >= 160 && Bus.Location.Y <= 170
                || Bus.Location.Y >= 572 && Bus.Location.Y <= 582))
            {
                Bus.Left -= speed;
                Bus.Image = player.LeftBus;
                Bus.Size = new Size(135, 47);
            }
            if (up && Bus.Top >= 0 && (Bus.Location.X >= 23 && Bus.Location.X <= 45 || Bus.Location.X >= 384 && Bus.Location.X <= 405
                || Bus.Location.X >= 844 && Bus.Location.X <= 865))
            {
                Bus.Top -= speed;
                Bus.Image = player.UpBus;
                Bus.Size = new Size(47, 135);
            }
            if (down && Bus.Top < ClientSize.Height - Bus.Height && (Bus.Location.X >= 23 && Bus.Location.X <= 45 || Bus.Location.X >= 384 && Bus.Location.X <= 405
                || Bus.Location.X >= 844 && Bus.Location.X <= 865))
            {
                Bus.Top += speed;
                Bus.Image = player.DownBus;
                Bus.Size = new Size(47, 135);
            }

            if (Bus.Bounds.IntersectsWith(Destination.Bounds))
            {
                score += 10;
                Destination.Visible = false;
                LabelScore.Text = "Score: " + score;
                EndLevel();
            }
        }

        // h[0] - > 4 steps  , h[1] -> 6 steps 

        private void FrmGameMap_Load(object sender, EventArgs e)
        {
            PopulateRandomLocations();
            SetRandomLocation();
            LabelUser.Text = $"User name: {player.Name}";
            LabelLevel.Text = "Level: 1";
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
            game.Level = level;
            game.Date = DateTime.Today;
            dt = duration + (minutes * 60);
            game.Duration = dt;
            game.gameID = id;
            game.Score = score;
            game.PlayerName = player.Name;

            player.gameList.Add(game);
            
        }

        public void EndLevel()
        {
            GameTimer.Stop();
            DurationTimer.Stop();
            SaveGameData();

            FormGameResult1 formGameResult = new FormGameResult1();
            formGameResult.LabelDurationResult.Text += PrintDuration();
            formGameResult.LabelUserResult.Text += player.Name;
            formGameResult.LabelScoreResult.Text += game.Score;
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

    }
}  