using System;
using Xunit;

namespace Tests
{
    public class BitTests
    {
        [Fact]
        public void BinaryAdd()
        {
            byte firstOne = BinaryToByte("10000000");
            byte secondHalf = BinaryToByte("00001111");
            byte result = (byte)(firstOne | secondHalf);
            AssertBinary("10001111", result);
        }

        [Fact]
        public void Negative()
        {
            byte number = BinaryToByte("11100000");
            byte negative = (byte)~number;
            AssertBinary("00011111", negative);
        }

        [Fact]
        public void TestAsserting()
        {
            AssertBinary("00001000", 8);
            AssertBinary("00000000", 0);
            AssertBinary("11111111", byte.MaxValue);
        }

        [Fact]
        public void TestParsing(){
            Assert.Equal(7, BinaryToByte("111"));
            Assert.Equal("00000111", ByteToBinary(7));
        }

        private void AssertBinary(string expectedBinary, byte value){
            var binary = ByteToBinary(value);
            Assert.Equal(expectedBinary, binary);
        }

        private string ByteToBinary(byte value)
        {
            string binary = Convert.ToString(value, 2);
            var missingZeros = new string('0', 8 - binary.Length);
            return missingZeros + binary;
        }

        private byte BinaryToByte(string binnary){
            return Convert.ToByte(binnary, 2);
        }
    }
}
