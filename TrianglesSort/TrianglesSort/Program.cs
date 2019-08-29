using System;
using System.Collections.Generic;
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
                    if(!triangles.AddTriangle(name, sides))
                    {
                        ConsoleUI.ShowMessage(StrConsts.DOESNT_EXIST);
                    }
                }
                ConsoleUI.AskContinue(StrConsts.CONTINUE);

            } while (ConsoleUI.WannaContinue);

            triangles.Reverse();
            ConsoleUI.ShowCollection<SortedSet<Triangle>, Triangle>(triangles);
            ConsoleUI.Pause();
        }
    }
}
  