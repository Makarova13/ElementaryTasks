﻿namespace LuckyTicket
{
    class TicketAnalyser
    {
        public TicketAnalyser(ICheckIfLucky checkIfLucky, Ticket ticket)
        {
            CurrentTicket = ticket;
            Algorithm = checkIfLucky;
        }

        private Ticket CurrentTicket { get; set; }

        private ICheckIfLucky Algorithm { get; set; }

        public void CheckIfLucky(Ticket numbers)
        {
            Algorithm.CheckIfLucky(CurrentTicket);
        }
    }
}
