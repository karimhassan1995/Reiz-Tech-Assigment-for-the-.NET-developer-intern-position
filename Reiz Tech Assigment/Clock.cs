using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_Tech_Assigment
{
    public class Clock
    {
        private readonly static int DEGREES_PER_CIRCLE = 360;
        private readonly static int NUMBER_OF_HOURS = 12;
        private readonly static int MINUTES_PER_HOUR = 60;
        private readonly static int DEGREES_PER_HOUR = DEGREES_PER_CIRCLE / NUMBER_OF_HOURS;

        public int hour, minute;

        public Clock(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }

        public double CalculateAngle()
        {
            double hourDegree = (this.hour * DEGREES_PER_HOUR) + ((this.minute * 1.0 / MINUTES_PER_HOUR) * DEGREES_PER_HOUR);
            double minuteDegree = (this.minute * 1.0 / MINUTES_PER_HOUR) * DEGREES_PER_CIRCLE;

            double difference = Math.Abs(hourDegree - minuteDegree);
            return Math.Min(difference, 360 - difference);
        }
    }
}
