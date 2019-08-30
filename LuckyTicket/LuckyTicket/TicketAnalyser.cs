using System;

namespace LuckyTicket
{
    class TicketAnalyser
    {
        public TicketAnalyser(TicketType ticketType)
        {
            switch (ticketType)
            {
                case TicketType.Moskow:
                    Algorithm = new MoskowTicketAlgorithm();
                    break;

                case TicketType.Piter:
                    Algorithm = new PiterTicketAlgorithm();
                    break;
            }
        }

        public ICheckIfLucky Algorithm { private get; set; }

        public bool CheckIfLucky(byte[] numbers)
        {
            return Algorithm.CheckIfLucky(numbers);
        }
    }
}
