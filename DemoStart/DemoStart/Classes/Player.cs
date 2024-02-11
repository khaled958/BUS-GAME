using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStart.Class
{
    public class Player
    {
        public int MaxDuration, MinDuration, MaxScore, MinScore, TotalDuration;
        public List<Game> gameList = new List<Game>();
        public Bitmap LeftBus, RightBus, UpBus, DownBus;

        public COLOR Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public GENDER Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _name;
        private int _age;
        private GENDER _gender;
        private COLOR _color;

        public Player():this("UNKNOWN", 10, GENDER.Male ) { }
        public Player(string Name, int Age, GENDER Gender )
        {
            MaxDuration = 0;
            MinDuration = 100;
            MaxScore = 0;
            MinScore = 100;
            TotalDuration = 0;
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        public override bool Equals(object? obj)
        {
            Player? a = obj as Player;
            if (a == null) 
                return false;
            return a.Name.Equals(this.Name) && a.Age.Equals(this.Age) && a.Gender.Equals(this.Gender);
        }

        public void SetData()
        {
            TotalDuration = 0;
            foreach (Game g in gameList)
            {
                MaxDuration = Math.Max(MaxDuration, g.Duration);
            }
            foreach (Game g in gameList)
            {
                MinDuration = Math.Min(g.Duration, MinDuration);
            }
            foreach (Game g in gameList)
            {
                MaxScore = Math.Max(g.Score, MaxScore);
            }
            foreach (Game g in gameList)
            {
                MinScore = Math.Min(g.Score , MinScore);
            }
            foreach (Game g in gameList)
            {
                TotalDuration += g.Duration;
            }
        }
    }

    public enum COLOR
    {
        Red,
        Blue,
        Yellow
    }

    public enum GENDER
    { 
       Male,
       Female
    }
}
