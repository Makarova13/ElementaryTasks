using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TasksHelper
{
    public class Validator
    {
        public static bool ArgsAreInt(string[] str)
        {
            foreach(string s in str)
            {
                if(!int.TryParse(s, out int a))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPositive(double a)
        {
            return a >= 0.0;
        }

        public static bool CheckPath(string path)
        {
            return File.Exists(path);
        }
    }
}
