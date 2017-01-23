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
            this.TimeMin = 48;
        }
        public Basketball(bool overtime)
        {
            if (overtime == true)
            {
                Overtime = true;
                Console.WriteLine("How many overtime periods?\n");
                int periods1 = int.Parse(Console.ReadLine());
                periods = periods1;
                periodMin = 5;
                TimeMin = 48 + (periods * periodMin);
            }
            else if (overtime == false)
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
            Console.WriteLine("In basketball, the ball is round.\n");
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
