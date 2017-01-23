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

        //properties
        protected string BallShape
        {
            get { return ballShape; }
        }
        protected int TimeMin
        {
            get { return timeMin; }
        }
    }
}
