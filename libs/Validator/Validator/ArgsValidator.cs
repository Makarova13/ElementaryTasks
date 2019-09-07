using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    public class ArgsValidator: IArgsValidator
    {
        public int ArgsNumber { get; private set; }

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
    }
}
