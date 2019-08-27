using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace Fibonacci
{
    class Calculate
    {
        public static readonly List<int> fibonacciNum = new List<int>();

        public static void GetFibonacciNum(int min, int max)
        {
            if (min > max)
            {
                OperationsHelper.Swipe(ref min, ref max);
            }

            GetFibonacciNum(0, 1, min, max);
        }

        private static void GetFibonacciNum(int a, int b, int min, int max)
        {
            if (a <= min)
            {
                GetFibonacciNum(b, a + b, min, max);
            }
            else if (a <= max)
            {
                fibonacciNum.Add(a);
                GetFibonacciNum(b, a + b, min, max);
            }
        }
    }
}
