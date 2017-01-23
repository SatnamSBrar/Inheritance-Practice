using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_012317_Inheritance_Practice
{
    class Soccer : BallSport
    {
        public void PrintBallShape()
        {
            Console.WriteLine("In soccer, the ball is round.\n");
        }

        public void PrintTimeMin()
        {
            Console.WriteLine("Soccer games last 90 minutes.\n");
        }
    }
}
