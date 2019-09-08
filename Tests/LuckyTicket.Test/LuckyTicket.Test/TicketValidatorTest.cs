using Xunit;

namespace LuckyTicket.Test
{
    public class TicketValidatorTest
    {
        [Theory]
        [InlineData("123321", 123321)]
        [InlineData("001110", 1110)]
        [InlineData("999999", 999999)]
        public void ValidateRangeTest(string str, int expected)
        {
            int result = TicketValidator.ValidateRange(str);

            Assert.True(result == expected);
        }
    }
}
