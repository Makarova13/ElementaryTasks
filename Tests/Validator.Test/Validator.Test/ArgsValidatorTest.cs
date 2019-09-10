using System;
using Xunit;
using Validator;

namespace Validator.Test
{
    public class ArgsValidatorTest
    {
        [Theory]
        [InlineData(new string[]{"123321"}, true)]
        [InlineData(new string[] { "ajdhhsg" }, false)]
        [InlineData(new string[] { "111" }, true)]
        public void ArgsAreIntTest(string[] str, bool expected)
        {
            ArgsValidator validator = new ArgsValidator();
            bool result = validator.ArgsAreInt(str);

            Assert.True(result == expected);
        }

        [Theory]
        [InlineData(new string[] { "1221" }, true)]
        [InlineData(new string[] { "ajdhhsg" }, false)]
        [InlineData(new string[] { "111" }, true)]
        public void ArgsAreFloatTest(string[] str, bool expected)
        {
            ArgsValidator validator = new ArgsValidator();
            bool result = validator.ArgsAreInt(str);

            Assert.True(result == expected);
        }
    }
}
