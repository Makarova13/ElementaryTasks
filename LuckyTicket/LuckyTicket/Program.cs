using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.ShowMessage(Messages.ENTER_PATH);
            string path = ConsoleUI.ReadLine();
        }
    }
}
