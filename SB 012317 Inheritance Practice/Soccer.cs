using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_012317_Inheritance_Practice
{
    class Soccer : BallSport
    {
        //constructors
        public Soccer()
        {
            this.TimeMin = 90;
        }

        //methods
        public void PrintBallShape()
        {
            Console.WriteLine("In soccer, the ball is round.\n");
        }

        public void PrintTimeMin()
        {
            Console.WriteLine("This game will last " + TimeMin + " minutes.\n");
        }
    }
}
