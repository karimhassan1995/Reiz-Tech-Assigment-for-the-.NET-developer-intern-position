using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_Tech_Assigment
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            // First question in REIZ TECH HOMEWORK ASSIGNMENT 
            bool IsHourTrue = true;
            int hour = 0;

            while (IsHourTrue == true)
            {
                Console.WriteLine("Enter Hour: ");
            
                try
                {
                    hour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("plz Enter hour as int numbers");
                    continue;
                }
                if (hour > 12 || hour < 0)
                {
                    Console.WriteLine("plz Enter hour between 0 and 12");
                    continue;
                }
                IsHourTrue = false;
            }

            bool IsMinuteTrue = true;
            int minute = 0;
            while (IsMinuteTrue == true)
            {
                Console.WriteLine("Enter Minute: ");
               
                try
                {
                    minute = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine("plz Enter minute as int numbers");
                        continue;
                }
                if (minute > 60 || minute < 0)
                {
                    Console.WriteLine("plz minute number between 0 and 60");
                    continue;
                }
                IsMinuteTrue = false;
            }


            Clock clock = new Clock(hour, minute);
                Console.WriteLine($"Angle between hour hand and minute hand is" + " " + clock.CalculateAngle());





        }
    }
}
