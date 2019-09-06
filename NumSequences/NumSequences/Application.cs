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
        private ICalculate Culculation { get; }

        public Application(IUserInterface ui, ICalculate culculation)
        {
            UI = ui;
            Culculation = culculation;
            Run();
        }

        private void Run()
        {
            foreach (int num in Culculation)
            {
                UI.ShowNum(num);
                UI.Show(", ");
            }

            UI.Pause();
        }
    }
}
