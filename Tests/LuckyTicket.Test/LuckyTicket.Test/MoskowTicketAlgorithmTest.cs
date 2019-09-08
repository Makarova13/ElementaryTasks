using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LuckyTicket.Test
{
    public class MoskowTicketAlgorithmTest
    {
        [Theory]
        [InlineData(new byte[] { 1, 2, 0, 0, 2, 1 }, true)]
        [InlineData(new byte[] { 2, 5, 0, 3, 2, 2 }, true)]
        [InlineData(new byte[] { 2, 1, 2, 3, 0, 0 }, false)]
        [InlineData(new byte[] { 0, 1, 5, 3, 1, 3 }, false)]
        public void CheckIfLuckyTest(byte[] number, bool expected)
        {
            Ticket ticket = new Ticket
            { Number = number };

            var moskowTicket = new MoskowTicketAlgorithm();

            moskowTicket.CheckIfLucky(ticket);

            Assert.True(ticket.IsLucky == expected);
        }
    }
}
