using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TasksHelper;

namespace LuckyTicket
{
    class WorkWithFile
    {      
        public static int ReadAndCount(string path, ProcessTicket CheckTicket)
        {
            int countOfLucky = 0;
            string line;

            using (StreamReader file = new StreamReader(path, Encoding.Default))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Split().GetInt(Ticket.THE_NUMBER_OF_DIGITS, 0, out int[] numbers))
                    {
                        if (CheckTicket(numbers))
                        {
                            countOfLucky++;
                        }
                    }
                    else
                    {
                        ConsoleUI.ShowMessage(Messages.ERROR_NUMBER_FORMAT);
                    }
                }
            }

            return countOfLucky;
        }

    }
}
