﻿using System;
using OperationsWithNums;

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
            Ticket ticket = new Ticket();

            for (int i = min; i <= max; i++)
            {
                ticket.Number = new byte[Ticket.NumberLength];
                ticket.Number = Operations.ConvertToByteArray(i, Ticket.NumberLength);
                Algorithm.CheckIfLucky(ticket);

                if (ticket.IsLucky)
                {
                    AmountOfLucky++;
                }
            }
        }
    }
}