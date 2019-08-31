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

                if (triangleUI.GetTriangle(out string name, out int[] sides))
                {
                    if (!triangles.AddTriangle(name, sides))
                    {
                        UI.ShowMessage(StrConsts.DOESNT_EXIST);
                    }
                }

                UI.AskContinue(StrConsts.CONTINUE);

            } while (UI.WannaContinue);

            UI.ShowCollection<SortedSet<Triangle>, Triangle>(triangles);
            UI.Pause();
        }
    }
}
