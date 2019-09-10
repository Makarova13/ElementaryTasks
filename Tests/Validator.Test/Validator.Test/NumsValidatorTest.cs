using Xunit;

namespace Validator.Test
{
    public class NumsValidatorTest
    {
        [Theory]
        [InlineData(111, true)]
        [InlineData(-14, false)]
        [InlineData(99, true)]
        public void IsPositiveTest(int value, bool expected)
        {
            NumsValidator validator = new NumsValidator();
            bool result = validator.IsPositive(value);

            Assert.True(result == expected);
        }
    }
}
