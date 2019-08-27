using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredNums
{
    class Squared
    {
        public static List<int> nums = new List<int>();

        public static void FillTheList(int n)
        {
            for (int i = 0; (i * i) < n; i++)
            {
                nums.Add(i);
            }
        }
    }
}
