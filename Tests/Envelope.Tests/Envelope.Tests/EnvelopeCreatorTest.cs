using System;
using Xunit;
using Validator;

namespace Task2Envelope.Tests
{
    public class EnvelopeCreatorTest: IClassFixture<EnvelopeFixture>
    {
        private EnvelopeFixture fixture;

        public EnvelopeCreatorTest(EnvelopeFixture envelopeFixture)
        {
            fixture = envelopeFixture;
        }

        [Theory]
        [InlineData("3.4", "5.6")]
        [InlineData("ihvhbj", "hjbg")]
        [InlineData("L", "K")]
        public void CreateEnvelope_WithInvalidArgs_ShouldThrowException(string a, string b)
        {
            Assert.Throws<FormatException>(() => fixture.Creator.CreateEnvelope(a, b));
        }
    }
}
