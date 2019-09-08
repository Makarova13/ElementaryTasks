using System;
using OperationsWithNums;
using System.Linq;
using Xunit;

namespace OperationsWithNums.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, new byte[] { 2, 0, 0, 0, 0, 0 })]
        public void ConvertToByteArrayTest(int a, byte[] expected)
        {
            byte[] result = Operations.ConvertToByteArray(a, expected.Length);

            Assert.True(expected.SequenceEqual(result));
        }
    }
}
