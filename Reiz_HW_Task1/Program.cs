using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClockAngle angleObj = new ClockAngle(0, 0, 0);          
            InOut.Input(angleObj);
            InOut.Output(angleObj);
            Console.ReadKey();
        }
    }
}
