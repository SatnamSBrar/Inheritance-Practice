using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_012317_Inheritance_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Soccer soccerGame1 = new Soccer();
            soccerGame1.PrintBallShape();
            soccerGame1.PrintTimeMin();

            Basketball bballGame1 = new Basketball();
            bballGame1.PrintBallShape();
            bballGame1.PrintTimeMin();
        }
    }
}
