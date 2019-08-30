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
        public int CountOfLucky { get; private set; } = 0;
        TicketValidator validator = new TicketValidator();

        private string line;
        private char[] charArr;      

        public void CountLucky(string path)
        {           
            using (StreamReader file = new StreamReader(path, Encoding.Default))
            {
                Enum.TryParse(file.ReadLine(), out TicketType ticketType);

                if (!validator.ValideType(ticketType))
                {
                    throw new FormatException(Messages.ERROR_NO_ALGORITHM);
                }

                TicketAnalyser ticketAnalyser = new TicketAnalyser(ticketType);

                while ((line = file.ReadLine()) != null)
                {
                    charArr = line.ToCharArray();

                    if (charArr.TryGetByteArr(line.Length, out byte[] numbers))
                    {
                        if (ticketAnalyser.CheckIfLucky(numbers))
                        {
                            CountOfLucky++;
                        }
                    }
                    else
                    {
                        throw new FormatException(Messages.ERROR_NUMBER_FORMAT);
                    }
                }
            }
        }


    }
}
