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

        public static void Swipe(ref float a, ref float b)
        {
            float y = a;
            a = b;
            b = y;
        }
    }
}
