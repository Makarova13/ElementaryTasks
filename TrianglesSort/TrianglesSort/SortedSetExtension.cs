using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace TrianglesSort
{
    static class SortedSetExtension
    {
        public static void AddTriangle(this SortedSet<Triangle> list, string name, int[] sides)
        {

            if (Triangle.IsTriangleExists(sides[0], sides[1], sides[2]))
            {
                list.Add(new Triangle(name, sides[0], sides[1], sides[2]));
            }
            else
            {
                ConsoleUI.ShowMessage(StrConsts.DOESNT_EXIST);
            }
        }
    }
}
