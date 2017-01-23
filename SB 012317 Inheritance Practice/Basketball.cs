using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_012317_Inheritance_Practice
{
    class Basketball : BallSport
    {
        public void PrintBallShape()
        {
            Console.WriteLine("In basketball, the ball is round.\n");
        }

        public void PrintTimeMin()
        {
            Console.WriteLine("Basketball games last 48 minutes.\n");
        }
    }
}
