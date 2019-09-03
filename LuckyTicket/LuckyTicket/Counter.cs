using System;
using System.Text;
using System.IO;
using OperationsWithNums;

namespace LuckyTicket
{
    class Counter
    {
        #region Properties

        public int AmountOfLucky { get; private set; } = 0;
        private TicketValidator validator { get; set; }

        #endregion

        #region Fields

        private string line;
        private char[] charArr;
        private TicketAnalyser ticketAnalyser;
        private Ticket ticket;

        #endregion

        public void CountLucky(string path)
        {
            validator = new TicketValidator();
            ticket = new Ticket();

            using (StreamReader file = new StreamReader(path, Encoding.Default))
            {
                Enum.TryParse(file.ReadLine(), out TicketType ticketType);

                if (!validator.ValideType(ticketType, out ICheckIfLucky checkIfLucky))
                {
                    throw new FormatException(Messages.ERROR_NO_ALGORITHM);
                }

                ticketAnalyser = new TicketAnalyser(checkIfLucky, ticket);

                while ((line = file.ReadLine()) != null)
                {
                    CountInLine(line);
                }
            }
        }

        private void CountInLine(string line)
        {
            charArr = line.ToCharArray();

            if (validator.ValidateNumber(line, ticket))
            {
                ticketAnalyser.CheckIfLucky(ticket);
                if (ticket.IsLucky)
                {
                    AmountOfLucky++;
                }
            }
        }

    }
}
