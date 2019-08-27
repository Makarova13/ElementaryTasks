using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksHelper
{
    public class OperationsHelper
    {
        public static void Swipe(ref int a, ref int b)
        {
            int y = a;
            a = b;
            b = y;
        }

        public static void Swipe(ref double a, ref double b)
        {
            double y = a;
            a = b;
            b = y;
        }
    }
}
