using System;
using System.Text;
using System.IO;
using OperationsWithNums;

namespace LuckyTicket
{
    public class Counter
    {
        #region Properties

        public int AmountOfLucky { get; private set; } = 0;
        private TicketValidator Validator { get; set; }
        private TicketAnalyser TicketAnalyser { get; set; }
        private Ticket ticket { get; set; }

        #endregion

        public void CountLucky(string path)
        {
            Validator = new TicketValidator();
            ticket = new Ticket();

            using (StreamReader file = new StreamReader(path, Encoding.Default))
            {
                Enum.TryParse(file.ReadLine(), out TicketType ticketType);

                if (!Validator.ValideType(ticketType, out ICheckIfLucky checkIfLucky))
                {
                    throw new FormatException(Messages.ERROR_NO_ALGORITHM);
                }

                TicketAnalyser = new TicketAnalyser(checkIfLucky, ticket);
            }
        }

        private void CountInLine(string line)
        {
            TicketAnalyser.CheckIfLucky(ticket);
            if (ticket.IsLucky)
            {
                AmountOfLucky++;
            }
        }
    }
}
