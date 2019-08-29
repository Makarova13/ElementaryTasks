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
        public static int CountLucky(string path)
        {
            int countOfLucky = 0;
            string line;
            char[] charArr;

            using (StreamReader file = new StreamReader(path, Encoding.Default))
            {
                Enum.TryParse(file.ReadLine(), out TicketType ticketType);
                
                TicketAnalyser ticketAnalyser = new TicketAnalyser();

                if((ticketAnalyser.Algorithm = ticketAnalyser.GetAlgorithm(ticketType)) == null)
                {
                    throw new FormatException(Messages.ERROR_NO_ALGORITHM);
                }

                while ((line = file.ReadLine()) != null)
                {
                    charArr = line.ToCharArray();

                    if (charArr.TryGetByteArr(line.Length, out byte[] numbers))
                    {
                        if (ticketAnalyser.Algorithm.CheckIfLucky(numbers))
                        {
                            countOfLucky++;
                        }
                    }
                    else
                    {
                        throw new FormatException(Messages.ERROR_NUMBER_FORMAT);
                    }
                }
            }

            return countOfLucky;
        }

    }
}
