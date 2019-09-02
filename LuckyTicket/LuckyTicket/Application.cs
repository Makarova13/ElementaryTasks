using System;
using UserInterface;
using System.IO;

namespace LuckyTicket
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
            string path;
            UI.ShowMessage(Messages.ENTER_PATH);
            path = UI.ReadLine();

            if (!File.Exists(path))
            {
                UI.ShowMessage(Messages.ERROR_WRONG_PATH);
            }
            else
            {
                try
                {
                    Counter counter = new Counter();
                    counter.CountLucky(path);
                    UI.ShowMessage($"Count of lucky tickets: {counter.AmountOfLucky}");
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
