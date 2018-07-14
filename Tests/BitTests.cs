using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBinaryParsing()
        {
            AssertBinary("1000", 8);
        }

        private void AssertBinary(string expectedBinary, int value){
            string binary = Convert.ToString(value, 2);
            Assert.Equal(expectedBinary, binary);
        }
    }
}
