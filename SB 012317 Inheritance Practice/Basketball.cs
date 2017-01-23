using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_012317_Inheritance_Practice
{
    class Basketball : BallSport
    {
        //constructors
        public Basketball()
        {
            this.TimeMin = 48;
        }
        
        //methods
        public void PrintBallShape()
        {
            Console.WriteLine("In basketball, the ball is round.\n");
        }

        public void PrintTimeMin()
        {
            Console.WriteLine("This game will last " + TimeMin + " minutes.\n");
        }
    }
}
