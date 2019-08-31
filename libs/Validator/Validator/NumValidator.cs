using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    public class NumValidator
    {
        public bool ArgsAreInt(string[] str)
        {
            foreach (string s in str)
            {
                if (!int.TryParse(s, out int a))
                {
                    return false;
                }
            }
            return true;
        }

        public bool ArgsAreFloat(string[] str)
        {
            foreach (string s in str)
            {
                if (!float.TryParse(s, out float a))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsPositive(double a)
        {
            return a >= 0.0;
        }
    }
}
