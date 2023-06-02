using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_Tech_Assigment
{
    public class Clock
    {

        public int hour, minute;
      
        public Clock(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }

        public void CalculateAngle()
        {
            double hourDegree = (this.hour * 30) + (this.minute * 30 / 60);
            double minimumDegree = this.minute * 6;

            double difference = Math.Abs(hourDegree - minimumDegree);
            if (difference > 180)
            {
                difference = 360 - difference;
            }
            Console.WriteLine($"Angle between hour hand and minute hand is" + " " + difference);
            Console.ReadLine();
        }

            



        
    }
}
