using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStart.Classes
{
    internal class MovementRecord
    {
        int _steps;
        string _clicks;
        int _duration;

        public int Steps { get => _steps; set => _steps = value; }
        public string Clicks { get => _clicks; set => _clicks = value; }
        public int Duration { get => _duration; set => _duration = value; }
    }
}
