using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksHelper
{
    public class Operations
    {
        public static void Swipe<T>(ref T a, ref T b)
        {
            T y = a;
            a = b;
            b = y;
        }
    }
}
