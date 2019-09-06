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

        #region properties

        public int Min { get; }
        public int Max { get; }

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

        public IEnumerator<int> GetEnumerator()
        {
            while (currNum <= Max) 
            {
                if (currNum >= Min)
                {
                    yield return currNum;
                }

                nextNum = currNum + prevNum;
                prevNum = currNum;
                currNum = nextNum;
            }          
        }

    }
}
