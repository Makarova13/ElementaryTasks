using System;
using TasksHelper;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            ConsoleUI.ShowMessage(Messages.ENTER_PATH);
            path = ConsoleUI.ReadLine();

            if (!Validator.CheckPath(path))
            {
                ConsoleUI.ShowMessage(Messages.ERROR_WRONG_PATH);
            }
            else
            {
                try
                {
                    WorkWithFile withFile = new WorkWithFile();
                    withFile.CountLucky(path);
                    ConsoleUI.ShowMessage($"Count of lucky tickets: {withFile.CountOfLucky}");
                }
                catch (FormatException ex)
                {
                    ConsoleUI.ShowMessage(ex.Message);
                }
            }

            ConsoleUI.Pause();
        }
    }
}
