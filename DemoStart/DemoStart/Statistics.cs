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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        int HighestScore, LowestScore, MinimumDuration, MaximumDuration, TotalDuration;

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();            
        }

        int NoOfGames, NoOfProfile;

        private void Statistics_Load(object sender, EventArgs e)
        {
            if (StartPage.playerList.Count == 0)
            {
                ErrorMessage er = new ErrorMessage();
                er.StartPosition = FormStartPosition.CenterParent;
                er.ShowDialog();
                this.Close();
            }
            else
            {
                GetData();
                InsertData();
            }
        }
        public void GetData()
        {
            // Number of Profiles and Games
            NoOfGames = 0;
            var queryGames = from player in StartPage.playerList
                             select player.gameList.Count;
            NoOfGames = queryGames.Sum();

            // Highest Score
            var queryHighestScore = from player in StartPage.playerList
                        orderby player.MaxScore descending
                        select player.MaxScore;

            HighestScore = queryHighestScore.First();

            // Lowest Score
            var queryLowestScore = from player in StartPage.playerList
                              orderby player.MinScore
                              select player.MinScore;

            LowestScore = queryLowestScore.First();

            // Maximum and Minimum Duration
            var queryMaxDuration = from player in StartPage.playerList
                    orderby player.MaxDuration descending
                    select player.MaxDuration;

            MaximumDuration = queryMaxDuration.First();

            var queryMinDuration = from player in StartPage.playerList
                                   orderby player.MinDuration ascending
                                   select player.MinDuration;

            MinimumDuration = queryMinDuration.First();

            // Total Duration
            var queryTotalDuration = from player in StartPage.playerList
                                     select player.TotalDuration;
            TotalDuration = 0;
            foreach(var p in queryTotalDuration)
            {
                TotalDuration += p;
            }

            NoOfProfile = StartPage.playerList.Count;
        }
        public void InsertData()
        {
            if (NoOfGames > 0)
            {
                Statistics_grid.Rows.Add("Number of Games ", NoOfGames);
                Statistics_grid.Rows.Add("Number of Profiles ", NoOfProfile);
                Statistics_grid.Rows.Add("Highest Score ", HighestScore);
                Statistics_grid.Rows.Add("Lowest Score ", LowestScore);
                Statistics_grid.Rows.Add("Minimum Duration ", MinimumDuration);
                Statistics_grid.Rows.Add("Maximum Duration ", MaximumDuration);
                Statistics_grid.Rows.Add("Total Duration ", TotalDuration);
            }
            else
            {
                ErrorMessage er = new ErrorMessage();
                er.ShowDialog();
            }
        }
    }
}
