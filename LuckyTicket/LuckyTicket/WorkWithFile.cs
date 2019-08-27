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
        static int ReadAndCount(string path)
        {
            string reading;
            int countOfLucky = 0;
            string[] tickets;

            using (StreamReader file = new StreamReader(path, Encoding.Default))
            {
                reading = file.ReadLine();
                TicketType ticketType;

                try
                {
                    ticketType = Ticket.GetTicketType(reading);
                }
                catch(FormatException ex)
                {
                    throw new FormatException(ex.Message);
                }

                tickets = file.ReadToEnd().Split('\n');

                if (ticketType == TicketType.Moskow)  //TODO: split
                {
                    countOfLucky = (from t in tickets where t.Length == Ticket.THE_NUMBER_OF_DIGITS && 
                                    MoskowTicket.CheckIfLucky(t.StringToIntArray()) select t).Count();
                }

                if (ticketType == TicketType.Piter) 
                {
                    countOfLucky = (from t in tickets where t.Length == Ticket.THE_NUMBER_OF_DIGITS &&
                        PiterTicket.CheckIfLucky(t.StringToIntArray()) select t).Count();
                }
            }

            return countOfLucky;
        }


    }
}
