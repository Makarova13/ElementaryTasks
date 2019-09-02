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

        #endregion

        public void CountLucky(string path)
        {
            validator = new TicketValidator();

            using (StreamReader file = new StreamReader(path, Encoding.Default))
            {
                Enum.TryParse(file.ReadLine(), out TicketType ticketType);

                if (!validator.ValideType(ticketType, out ICheckIfLucky checkIfLucky))
                {
                    throw new FormatException(Messages.ERROR_NO_ALGORITHM);
                }

                ticketAnalyser = new TicketAnalyser(checkIfLucky);

                while ((line = file.ReadLine()) != null)
                {
                    CheckLine(line);
                }
            }
        }

        private void CheckLine(string line)
        {
            charArr = line.ToCharArray();

            if (charArr.TryGetByteArr(line.Length, out byte[] numbers))
            {
                if (ticketAnalyser.CheckIfLucky(numbers))
                {
                    AmountOfLucky++;
                }
            }
            else
            {
                throw new FormatException(Messages.ERROR_NUMBER_FORMAT);
            }
        }
    }
}
