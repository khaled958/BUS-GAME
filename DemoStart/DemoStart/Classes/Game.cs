using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStart.Class
{
    public class Game
    {
        //public List<Tuple<string, float>> steps = new List<Tuple<string, float>>();
        public List<Tuple<int, string, int>> steps = new List<Tuple<int, string, int>>();

        private string _playerName;
        public string PlayerName
        {
            get 
            { 
                return _playerName; 
            }
            set
            {
                _playerName = value;
            }
        }
        static int id = 0;

        private int _level;
        public int Level
        {
            get
            {
                return _level;
            }

            set
            {
                this._level = value;
            }
        }

        private int _score;
        public int Score
        {
            get
            {
                return _score;
            }

            set
            {
                this._score = value;
            }
        }

        private int _duration;
        public int Duration
        {
            get
            {
                return _duration;
            }

            set
            {
                this._duration = value;
            }
        }

        public DateTime _date;
        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                this._date = value;

            }
        }

        private int _gameID;
        public int gameID
        {
            get
            {
                return _gameID;
            }

            set
            {
                this._gameID = value;
            }
        }


        public Game()
        {
            _level = 1;
            _score = 0;
            _duration = 0;
            _date = DateTime.Today;
            _gameID = id++;
            _playerName = "";
        }


        public Game(Game game)
        {
            this._level = game.Level;
            this._score = game.Score;
            this._duration = game._duration;
            this._date = game.Date;
            this._gameID = game.gameID;
            this._playerName = game.PlayerName;
        }

        public override bool Equals(Object obj)
        {
            Game game = obj as Game;

            if (game != null)
            {
                return this._level.Equals(game.Level) &&
                        this._score.Equals(game.Score) &&
                        this._duration.Equals(game.Duration) &&
                        this._date.Equals(game.Date) &&
                        this._gameID.Equals(game.gameID) &&
                        this._playerName.Equals(game.PlayerName);
            }
            return false;
        }

        public override string ToString()
        {
            //return string.Format("Level: {0}" +
            //    "\n Score: {1}" +
            //    "\n Time: {2}" +
            //    "\n Date: {3}"
            //    , _level, _score, _duration, _date
            //    );
            return PlayerName;
        }
    }

}
