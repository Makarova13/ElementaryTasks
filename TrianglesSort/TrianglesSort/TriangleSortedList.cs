using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesSort
{
    class TriangleSortedList
    {
        public readonly SortedSet<Triangle> triangles;

        public TriangleSortedList()
        {
            triangles = new SortedSet<Triangle>();
        }

        public void Add(string name, int[] sides)
        {
            try
            {
                if (Triangle.IsTriangleExists(sides[0], sides[1], sides[2]))
                {
                    triangles.Add( new Triangle(name, sides[0], sides[1], sides[2]));
                }
                else
                {
                    throw new TriangleException("A triangle with such sides does not exist.");
                }
            }
            catch (TriangleException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    }
}
