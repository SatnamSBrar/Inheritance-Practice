using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_012317_Inheritance_Practice
{
    class Basketball : BallSport
    {
        //fields
        protected int periods;
        protected int periodMin = 5;
        protected int overtimeMin;

        //constructors
        public Basketball()
        {
            BallShape = "round";

            Console.WriteLine("Is there any overtime? Enter yes or no:\n");
            string extraTime = Console.ReadLine();
            extraTime.ToLower();
            if (extraTime == "yes")
            {
                Overtime = true;
                Console.WriteLine("How many overtime periods?\n");
                int periods1 = int.Parse(Console.ReadLine());
                periods = periods1;
                periodMin = 5;
                TimeMin = 48 + (periods * periodMin);
            }
            else if (extraTime == "no")
            {
                Overtime = false;
                TimeMin = 48;
            }
        }

        //properties
        protected int OvertimeMin
        {
            get { return overtimeMin; }
            set { overtimeMin = TimeMin + (periods * periodMin); }
        }

        //methods
        public void PrintBallShape()
        {
            Console.WriteLine("\nIn basketball, the ball is " + BallShape + ".\n");
        }

        public void PrintTimeMin()
        {
            if (Overtime == false)
            {
                Console.WriteLine("This game will last " + TimeMin + " minutes.\n");
            }
            else if (Overtime == true)
            {
                Console.WriteLine("This game will last " + OvertimeMin + " minutes.\n");
            }
        }
    }
}
