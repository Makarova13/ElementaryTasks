using System;
using Xunit;
using UserInterface;
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
            ConsoleUI UI = new ConsoleUI();
            INumsValidator numsValidator = new NumsValidator();

            EnvelopeCreator creator = new EnvelopeCreator(UI, numsValidator);
            Assert.Throws<FormatException>(() => creator.CreateEnvelope(a, b));
        }
    }
}
