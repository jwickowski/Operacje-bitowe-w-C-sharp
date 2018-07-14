using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAsserting()
        {
            AssertBinary("1000", 8);
            AssertBinary("0", 0);
        }

        private void AssertBinary(string expectedBinary, int value){
            var binary = IntToBinary(value);
            Assert.Equal(expectedBinary, binary);
        }

        private string IntToBinary(int value)
        {
            string binary = Convert.ToString(value, 2);
            return binary;
        }

        private int BinaryToInt(string binnary){
            return Convert.ToInt32(binnary, 2);
        }
    }
}
