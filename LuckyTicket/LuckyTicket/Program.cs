using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace LuckyTicket
{
    delegate bool ProcessTicket(int[] number);

    class Program
    {
        static void Main(string[] args)
        {
            string path;

            if (!(TicketAnalyser.TryGetAlgorithm(args[0], out ProcessTicket process)))
            {
                ConsoleUI.ShowMessage(Messages.HELP);
            }
            else
            {
                ConsoleUI.ShowMessage(Messages.ENTER_PATH);

                path = ConsoleUI.ReadLine();

                if (!Validator.CheckPath(path)) 
                {
                    ConsoleUI.ShowMessage(Messages.ERROR_WRONG_PATH);
                }
                else
                {
                    WorkWithFile.ReadAndCount(path, process);
                }
            }

            ConsoleUI.Pause();
        }
    }
}
