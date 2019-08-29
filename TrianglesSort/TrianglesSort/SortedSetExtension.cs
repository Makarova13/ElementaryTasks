using System.Collections.Generic;

namespace TrianglesSort
{
    static class SortedSetExtension
    {
        public static bool AddTriangle(this SortedSet<Triangle> list, string name, int[] sides)
        {
            if (Triangle.IsTriangleExists(sides[0], sides[1], sides[2]))
            {
                list.Add(new Triangle(name, sides[0], sides[1], sides[2]));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
