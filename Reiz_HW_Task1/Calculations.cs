using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_HW_Task1
{
    internal class Calculations
    {
        /* Method for calculating the angle between hour and minute arrow indicators.
         */
        public static void CalculateAngle(ClockAngle angleObj)
        {
            angleObj.Angle = ((360 / 12) * angleObj.Hours - (360 / 60) * angleObj.Minutes);
        }
    }
}
