using Xunit;

namespace LuckyTicket.Test
{
    public class TicketAnalyserTest
    {
        const int AmountOfLuckyInMaxRange = 55252;
        
        [Fact]
        public void CheckAll_WithMaxRangeWithPiterAlgorithm_ShouldReturnExpectedAmount()
        {
            var ticketAnalyserPiter = new TicketsAnalyser(
                new PiterTicketAlgorithm());

            ticketAnalyserPiter.CheckAll(0, 999999);
            int result = ticketAnalyserPiter.AmountOfLucky;

            Assert.True(result == AmountOfLuckyInMaxRange);
        }

        [Fact]
        public void CheckAll_WithMaxRangeWithMoskowAlgorithm_ShouldReturnExpectedAmount()
        {
            var ticketAnalyserMoskow = new TicketsAnalyser(
                new MoskowTicketAlgorithm());

            ticketAnalyserMoskow.CheckAll(0, 999999);
            int result = ticketAnalyserMoskow.AmountOfLucky;

            Assert.True(result == AmountOfLuckyInMaxRange);
        }
    }
}
