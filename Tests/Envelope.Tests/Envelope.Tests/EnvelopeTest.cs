using Xunit;

namespace Task2Envelope.Tests
{
    public class EnvelopeTest
    {
        [Theory]
        [InlineData(3.4F, 5.55F, 3.3F, 5.5F, true)]
        [InlineData(3.1F, 7, 3.7F, 7.5F, true)]
        [InlineData(3.4F, 5.6F, 3.4F, 5.5F, false)]
        [InlineData(0.5F, 1.3F, 1.3F, 0.5F, false)]
        public void TestPutIn(float a, float b, float c, float d, bool expected)
        {
            Envelope en1 = new Envelope(a, b);
            Envelope en2 = new Envelope(c, d);

            bool result = en1.CheckPutIn(en2);

            Assert.True(result == expected);
        }

        [Theory]
        [InlineData(3.4F, 5.501F, 3.4F, 5.501F, true)]
        [InlineData(3.4F, 5.6F, 3.4F, 5.5F, false)]
        [InlineData(0.5F, 1.3F, 1.3F, 0.5F, true)]
        public void TestEquals(float a, float b, float c, float d, bool expected)
        {
            Envelope en1 = new Envelope(a, b);
            Envelope en2 = new Envelope(c, d);

            bool result = en1.Equals(en2);

            Assert.True(result == expected);
        }

        [Theory]
        [InlineData(1.1F, 3.501F, 3.4F, 5.501F, true)]
        [InlineData(3.4F, 5.6F, 3.4F, 5.5F, false)]
        [InlineData(0.5F, 0.3F, 1.3F, 2.5F, true)]
        public void TestLess(float a, float b, float c, float d, bool expected)
        {
            Envelope en1 = new Envelope(a, b);
            Envelope en2 = new Envelope(c, d);

            bool result = en1 < en2;

            Assert.True(result == expected);
        }

        [Theory]
        [InlineData(1.1F, 3.501F, 3.4F, 5.501F, false)]
        [InlineData(3.4F, 5.6F, 3.4F, 5.5F, false)]
        [InlineData(0.5F, 0.3F, 1.3F, 2.5F, false)]
        public void TestMore(float a, float b, float c, float d, bool expected)
        {
            Envelope en1 = new Envelope(a, b);
            Envelope en2 = new Envelope(c, d);

            bool result = en1 > en2;

            Assert.True(result == expected);
        }
    }
}
