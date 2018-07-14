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

        [Fact]
        public void TestParsing(){
            Assert.Equal(7, BinaryToByte("111"));
            Assert.Equal("111", IntToBinary(7));
        }

        private void AssertBinary(string expectedBinary, byte value){
            var binary = IntToBinary(value);
            Assert.Equal(expectedBinary, binary);
        }

        private string IntToBinary(byte value)
        {
            string binary = Convert.ToString(value, 2);
            return binary;
        }

        private byte BinaryToByte(string binnary){
            return Convert.ToByte(binnary, 2);
        }
    }
}
