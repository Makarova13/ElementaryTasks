using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    public interface IArgsValidator
    {
        bool ArgsAreInt(string[] str);
        bool ArgsAreFloat(string[] str);
    }
}
