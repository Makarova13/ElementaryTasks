using System;
using Xunit;
using NLog;
using Validator;

namespace Task2Envelope.Tests
{
    public class EnvelopeCreatorTest
    {
        [Theory]
        [InlineData("3.4", "5.6")]
        [InlineData("ihvhbj", "hjbg")]
        [InlineData("L", "K")]
        public void TestCreateEnvelope(string a, string b)
        {
            INumsValidator numsValidator = new NumsValidator();
            IArgsValidator argsValidator = new ArgsValidator();


            EnvelopeCreator creator = new EnvelopeCreator(numsValidator, argsValidator);
            Assert.Throws<FormatException>(() => creator.CreateEnvelope(a, b));
        }
    }
}
