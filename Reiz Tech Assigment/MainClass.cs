using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_Tech_Assigment
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {

            // First question in REIZ TECH HOMEWORK ASSIGNMENT 
            Console.WriteLine("Enter Hour: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            Clock clock = new Clock(hour , minute);


            clock.CalculateAngle();
        }
    }
}
