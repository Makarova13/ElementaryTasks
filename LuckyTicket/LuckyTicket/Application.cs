using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace LuckyTicket
{
    class Application
    {
        public IUserInterface UI { get; }
        //public IValidate Validator { get; }

        public Application(IUserInterface ui)
        {
            UI = ui;
            Run();
        }

        public void Run()
        {
            string path;
            UI.ShowMessage(Messages.ENTER_PATH);
            path = UI.ReadLine();

            if (!Validator.CheckPath(path))
            {
                UI.ShowMessage(Messages.ERROR_WRONG_PATH);
            }
            else
            {
                try
                {
                    WorkWithFile withFile = new WorkWithFile();
                    withFile.CountLucky(path);
                    UI.ShowMessage($"Count of lucky tickets: {withFile.CountOfLucky}");
                }
                catch (FormatException ex)
                {
                    UI.ShowMessage(ex.Message);
                }
            }

            UI.Pause();
        }
    }
}
