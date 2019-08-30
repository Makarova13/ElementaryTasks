using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

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

        public void Run()
        {
            SortedSet<Triangle> triangles = new SortedSet<Triangle>();

            int[] sides;
            string name;

            TriangleUI triangleUI = new TriangleUI(UI);
            do
            {
                UI.Clear();
                if (triangleUI.GetTriangle(out name, out sides))
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
