using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_012317_Inheritance_Practice
{
    class BallSport
    {
        //fields
        private string ballShape;
        private int timeMin;
        private bool overtime;
        protected string bestPlayer;
        protected string position;

        //properties
        protected string BallShape
        {
            get { return ballShape; }
            set { this.ballShape = value; }
        }
        protected int TimeMin
        {
            get { return timeMin; }
            set { timeMin = value; }
        }
        protected bool Overtime
        {
            get { return overtime; }
            set { overtime = false; }
        }

        //constructors
        protected BallSport()
        { }

        protected BallSport(string bestPlayer)
        {
            this.bestPlayer = bestPlayer;
        }

        //methods
        public virtual void PrintInfo()
        {
            Console.WriteLine("\nReal sports require balls.\n");
        }
    }
}
