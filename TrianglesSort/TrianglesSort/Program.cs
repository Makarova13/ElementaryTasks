using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TasksHelper;


namespace TrianglesSort
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Triangle> triangles = new SortedSet<Triangle>();

            int[] sides;
            string name;

            do
            {
                if (TrangleUI.GetTriangle(out name, out sides))
                {
                    triangles.AddTriangle(name, sides);
                }
                ConsoleUI.AskContinue(StrConsts.CONTINUE);

            } while (ConsoleUI.WannaContinue);

            triangles.Reverse();
            ConsoleUI.ShowCollection<SortedSet<Triangle>, Triangle>(triangles);
            ConsoleUI.Pause();
        }
    }
}
  