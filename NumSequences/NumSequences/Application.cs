using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;

namespace NumSequences
{
    class Application
    {
        private IUserInterface UI { get; }
        private ICalculate Algorithm { get; }

        public Application(IUserInterface ui, ICalculate algorithm)
        {
            UI = ui;
            Algorithm = algorithm;
            Run();
        }

        private void Run()
        {
            foreach (int num in Algorithm)
            {
                UI.ShowNum(num);
                UI.Show(", ");
            }

            UI.Pause();
        }
    }
}
