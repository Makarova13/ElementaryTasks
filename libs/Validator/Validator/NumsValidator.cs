using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    public class NumsValidator: INumsValidator
    {
        public bool IsPositive(double a)
        {
            return a >= 0.0;
        }
    }
}
