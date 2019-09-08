using Xunit;

namespace LuckyTicket.Test
{
    public class TicketAnalyserTest
    {
        [Theory]
        [InlineData(TicketType.Piter)]
        [InlineData(TicketType.Moskow)]
        public void CheckAllTest(TicketType ticketType)
        {
            int result = 0;
            int expected = 55252;
            ICheckIfLucky lucky = null;

            switch (ticketType)
            {
                case TicketType.Moskow:
                     lucky = new MoskowTicketAlgorithm();
                     break;

                case TicketType.Piter:
                    lucky = new PiterTicketAlgorithm();
                    break;
            }

            TicketsAnalyser ticketsAnalyser = new TicketsAnalyser(
                       lucky, 0, 999999);
            result = ticketsAnalyser.AmountOfLucky;

            Assert.True(result == expected);
        }
    }
}
