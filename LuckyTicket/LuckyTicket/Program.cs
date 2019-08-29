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

            int countOfLucky = 0;

            if (!Validator.CheckPath(path))
            {
                ConsoleUI.ShowMessage(Messages.ERROR_WRONG_PATH);
            }
            else
            {
                try
                {
                    countOfLucky = WorkWithFile.CountLucky(path);
                    ConsoleUI.ShowMessage($"Count of lucky tickets: {countOfLucky}");
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
