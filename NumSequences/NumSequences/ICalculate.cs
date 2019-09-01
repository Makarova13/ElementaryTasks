using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSequences
{
    interface ICalculate
    {
        IEnumerator<int> GetEnumerator();
    }
}
