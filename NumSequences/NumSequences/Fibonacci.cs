using System;
using System.Collections;
using System.Collections.Generic;
using OperationsWithNums;

namespace NumSequences
{
    class Fibonacci : ICalculate
    {
        #region fields

        private int currNum = 1;
        private int nextNum = 0;
        private int prevNum = 0;

        #endregion

        public Fibonacci(int min, int max)
        {
            if(min > max)
            {
                Operations.Swipe(ref min, ref max);
            }

            Min = min;
            Max = max;
        }

        #region properties

        public int Min { get; }
        public int Max { get; }

        #endregion

        public IEnumerator<int> GetEnumerator()
        {
            if (IsFibonacci(Min))
            {
                currNum = Min;
            }

            while (currNum <= Max) 
            {
                if (currNum >= Min)
                {
                    yield return currNum;
                }

                nextNum = currNum + prevNum;
                prevNum = currNum;
                currNum = nextNum;
                GetEnumerator();
            }          
        }

        private bool IsFibonacci(int a)
        {
            return (Math.Sqrt(a * a * 5 + 4) % 1 == 0 || Math.Sqrt(a * a * 5 - 4) % 1 == 0);
        }
    }
}
