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

        //properties
        protected string BallShape
        {
            get { return ballShape; }
            set { ballShape = "round"; }
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
    }
}
