using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSequences
{
    class LessThenSquaredNum : ICalculate
    {

        public int Max { get; private set; }

        public LessThenSquaredNum(int max)
        {
            Max = max;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; (i * i) < Max; i++)
            {
                yield return i;
            }
        }
    }
}
