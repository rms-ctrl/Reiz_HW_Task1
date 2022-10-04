using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_HW_Task1
{
    internal class InOut
    {
        /* Method to check if the input is valid.
         * Redirects to calculation method if so.
         */
        public static void Input(ClockAngle angleObj)
        {
            Console.WriteLine("Enter the desired hours:");
            _ = int.TryParse(Console.ReadLine(), out int hours);
                     
            Console.WriteLine("Enter the desired minutes:");
            _ = int.TryParse(Console.ReadLine(), out int minutes);

            if ((hours <= 12 && hours > 0) && (minutes <= 60 && minutes > 0))
            {
                angleObj.Hours = hours;
                angleObj.Minutes = minutes;
                Calculations.CalculateAngle(angleObj);
            }
            else
            {
                Console.WriteLine("\nThe input is invalid.\n" +
                    "Hours should be in the range of 0-12\n" +
                    "Minutes should be in the range of 0-60");
            }
            Console.WriteLine();
        }

        /* Method for redirecting to the Output method. Checks whether the Hours and minutes are valid.
         */
        public static void Output(ClockAngle angleObj)
        {
            if (angleObj.Hours == 0 || angleObj.Minutes == 0)
            {
                Console.WriteLine("The hours and minutes have not been set properly.");
            }
            else
            {
                OutputCases(angleObj);
            }
        }

        /* Output method for checking all the possible cases.
         */
        private static void OutputCases(ClockAngle angleObj)
        {
            switch (Math.Abs(angleObj.Angle))
            {
                case 0:
                    Console.WriteLine("The angle is equal to 0.");
                    break;
                case 180:
                    Console.WriteLine("The angle is {0}. Both angles are equal.", Math.Abs(angleObj.Angle));
                    break;
                default:
                    if (angleObj.Angle > (360 - angleObj.Angle))
                    {
                        Console.WriteLine("The lesser angle is {0} degrees.", Math.Abs(360 - angleObj.Angle));
                    }

                    else if (angleObj.Angle < (360 - angleObj.Angle))
                    {
                        Console.WriteLine("The lesser angle is {0} degrees.", Math.Abs(angleObj.Angle));
                    }
                    break;
            }
        }
    }
}
