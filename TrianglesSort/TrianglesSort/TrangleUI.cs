using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace TrianglesSort
{
    class TrangleUI
    {
        const int NUMBER_OF_SIDES = 3;

        public static bool GetTriangle(out string name, out int[] sides)
        {
            ConsoleUI.ShowMessage(StrConsts.INPUT_TRIANGLE);
            string[] triangle = ConsoleUI.ReadLine(',');
            name = triangle[0];

            return triangle.GetInt(NUMBER_OF_SIDES, 1, out sides);  // 1 is the index of symbol in string array which tells where is the int's begining
        }
    }
}
