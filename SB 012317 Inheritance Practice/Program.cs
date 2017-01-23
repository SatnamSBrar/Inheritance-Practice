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
            Console.WriteLine("Soccer game information:\n");
            Soccer soccerGame1 = new Soccer("left wing");
            soccerGame1.PrintBallShape();
            soccerGame1.BestPlayer();
            soccerGame1.PrintTimeMin();

            Console.WriteLine("\nBasketball game information:\n");
            Basketball bballGame1 = new Basketball("power forward");
            bballGame1.PrintBallShape();
            bballGame1.BestPlayer();
            bballGame1.PrintTimeMin();
        }
    }
}
