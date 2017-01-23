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
        public Soccer(bool overtime)
        {
            if (overtime == true)
            {
                Overtime = true;
                TimeMin = 120;
            }
            else if (overtime == false)
            {
                Overtime = false;
                TimeMin = 90;
            }
        }

        //methods
        public void PrintBallShape()
        {
            Console.WriteLine("In soccer, the ball is round.\n");
        }

        public void PrintTimeMin()
        {
            if (Overtime == false)
            {
                Console.WriteLine("This game will last " + TimeMin + " minutes.\n");
            }
            else if (Overtime == true)
            {
                Console.WriteLine("This game will last " + TimeMin + " minutes.\n");
            }
        }
    }
}
