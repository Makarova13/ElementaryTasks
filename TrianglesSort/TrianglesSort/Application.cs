using System.Collections.Generic;
using UserInterface;

namespace TrianglesSort
{
    class Application
    {
        public IUserInterface UI { get; }

        public Application(IUserInterface ui)
        {
            UI = ui;
            Run();
        }

        private void Run()
        {
            SortedSet<Triangle> triangles = new SortedSet<Triangle>();
            TriangleUI triangleUI = new TriangleUI(UI);

            do
            {
                UI.Clear();

                if (!triangleUI.GetTriangle(out string name, out int[] sides))
                {
                    UI.ShowMessage(StrConsts.FORMAT_ERROR);                
                }
                else
                {
                    if (!Triangle.IsTriangleExist(sides[0], sides[1], sides[2])) 
                    {
                        UI.ShowMessage(StrConsts.DOESNT_EXIST);
                    }
                    else
                    {
                        triangles.Add(new Triangle(name, sides[0], sides[1], sides[2]));
                    }
                }

                UI.AskContinue(StrConsts.CONTINUE);

            } while (UI.WannaContinue);

            UI.ShowCollection<SortedSet<Triangle>, Triangle>(triangles);
            UI.Pause();
        }
    }
}
