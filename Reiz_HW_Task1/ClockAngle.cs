using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_HW_Task1
{
    internal class ClockAngle
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public double Angle { get; set; }

        public ClockAngle(int hours, int minutes, double angle)
        {
            Hours = hours;
            Minutes = minutes;
            Angle = angle;
        }
    }
}
