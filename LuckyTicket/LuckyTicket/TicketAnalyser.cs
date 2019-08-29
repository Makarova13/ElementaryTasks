using System;

namespace LuckyTicket
{
    class TicketAnalyser
    {
        public const int THE_NUMBER_OF_DIGITS = 6;

        public ICheckIfLucky Algorithm { get; set; }

        public ICheckIfLucky GetAlgorithm(TicketType ticketType)
        {
            switch (ticketType)
            {
                case TicketType.Moskow:
                    return new MoskowTicketAlgorithm();

                case TicketType.Piter:
                    return new PiterTicketAlgorithm();

                default:
                    return null;
            }
        }

        internal bool CheckIfLucky(byte[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
