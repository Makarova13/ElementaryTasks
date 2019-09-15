using Xunit;

namespace LuckyTicket.Test
{
    public class MoskowTicketAlgorithmTest: IClassFixture<LuckyTicketFixture>
    {
        private readonly LuckyTicketFixture algorithm;

        public MoskowTicketAlgorithmTest(LuckyTicketFixture luckyTicketFixture)
        {
            algorithm = luckyTicketFixture;
        }

        [Theory]
        [InlineData(new byte[] { 1, 2, 0, 0, 2, 1 }, true)]
        [InlineData(new byte[] { 2, 5, 0, 3, 2, 2 }, true)]
        [InlineData(new byte[] { 2, 1, 2, 3, 0, 0 }, false)]
        [InlineData(new byte[] { 0, 1, 5, 3, 1, 3 }, false)]
        public void CheckIfLucky_WithNumber_ShouldReturnLuckyOrNot(byte[] number, bool expected)
        {
            Ticket ticket = new Ticket
            { Number = number };

            algorithm.MoskowAlgorithm.CheckIfLucky(ticket);

            Assert.True(ticket.IsLucky == expected);
        }
    }
}