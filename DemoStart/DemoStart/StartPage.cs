using System.Data;
using System.Media;
using DemoStart.Class;
using System.Threading;
using DemoStart.Classes;

namespace DemoStart
{
    public partial class StartPage : Form
    {
        public static List<Player> playerList = new List<Player>();
        public static Player player;
        public static List<HistoryClass> history = new List<HistoryClass>();

        public StartPage()
        {
            player = new Player();
            //Sound();
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_COMPOSITED = 0x02000000;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }

        private void Sound()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.MagicBus__mp3cut_net_);
            player.Play();
        }
        private void StartScreenTimer_Tick(object sender, EventArgs e)
        {
            StartBus.Left += 20;
            if (StartBus.Left >= (ClientSize.Width))
            {
                StartBus.Left = -StartBus.Left;
            }
            StartBus.Top = ClientSize.Height - StartBus.Height - 20;
        }

        private void newProfileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewProfile Pr = new NewProfile();
            Pr.ShowDialog();
        }

        private void currentProfileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CurrentProfiles cr = new CurrentProfiles();
            cr.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide() ;
            NewGame ng = new NewGame();
            ng.ShowDialog();
        }
        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.ShowDialog();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;            
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history2 = new History();
            history2.ShowDialog();


            //History history = new History();
            //history.ShowDialog();


            //int count;
            //foreach (var g in Test.Level1.player.gameList)
            //{
            //    count = 1;
            //    for (int i = 0; i < g.steps.Count; i++)
            //    {
            //        if (i == 0)
            //        {
            //            textBox1.Text += g.steps[i].Item1 + " " + g.steps[i].Item2 + Environment.NewLine;
            //        }
            //        else
            //        {
            //            textBox1.Text += g.steps[i].Item1 + " " + Math.Abs(g.steps[i].Item2 - g.steps[i - 1].Item2) + Environment.NewLine;
            //        }
            //    }
            //}
        }

        private void playBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Steps steps = new Steps();
            steps.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}