using System;

namespace LuckyTicket
{
    public class TicketsAnalyser
    {
        #region properties

        public int AmountOfLucky { get; private set; } = 0;
        private ICheckIfLucky Algorithm { get; set; }

        #endregion

        public TicketsAnalyser(ICheckIfLucky checkIfLucky, int min, int max)
        {
            Algorithm = checkIfLucky;
            CheckAll(min, max);
        }

        public void CheckAll(int min, int max)
        {
            Ticket ticket = new Ticket
            {
                Number = new byte[Ticket.NumberLength]
            };


            for (int i = min; i < max; i++)
            {
                ticket.Number = BitConverter.GetBytes(i);
                Algorithm.CheckIfLucky(ticket);

                if (ticket.IsLucky)
                {
                    AmountOfLucky++;
                }
            }
        }
    }
}
