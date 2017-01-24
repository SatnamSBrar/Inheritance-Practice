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
        public Soccer(string position) : base ("Ronaldo")
        {
            this.position = position;

            BallShape = "round";

            Console.WriteLine("Is there any overtime? Enter yes or no:\n");
            string extraTime = Console.ReadLine();
            extraTime.ToLower();
            if (extraTime == "yes")
            {
                Overtime = true;
                TimeMin = 120;
            }
            else if (extraTime == "no")
            {
                Overtime = false;
                TimeMin = 90;
            }
        }

        //methods
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("In soccer, the ball is " + BallShape + ".\n");
        }
        public void BestPlayer()
        {
            Console.WriteLine("The best player, " + bestPlayer + ", plays " + position + ".\n");
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
