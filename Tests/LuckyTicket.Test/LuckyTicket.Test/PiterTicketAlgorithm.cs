using Xunit;

namespace LuckyTicket.Test
{
    public class PiterTicketAlgorithmTest : IClassFixture<LuckyTicketFixture>
    {
        private readonly PiterTicketAlgorithm piterAlgorithm;

        public PiterTicketAlgorithmTest(PiterTicketAlgorithm piterTicket)
        {
            piterAlgorithm = piterTicket;
        }
    
        [Theory]
        [InlineData(new byte[] { 1, 2, 0, 3, 3, 0 }, false)]
        [InlineData(new byte[] { 0, 2, 0, 3, 3, 0 }, false)]
        [InlineData(new byte[] { 2, 1, 2, 3, 0, 0 }, true)]
        [InlineData(new byte[] { 0, 1, 5, 3, 1, 2 }, true)]
        [InlineData(new byte[] { 0, 0, 2, 2, 1, 1 }, true)]
        public void CheckIfLucky_WithNumber_ShouldReturnLuckyOrNot(byte[] number, bool expected)
        {
            Ticket ticket = new Ticket
            { Number = number };

            var piterTicket = new PiterTicketAlgorithm();

            piterTicket.CheckIfLucky(ticket);

            Assert.True(ticket.IsLucky == expected);
        }
    }
}
