using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeNumbers.TEST
{
    public class PrimeCheckTEST
    {
        [Theory]
        [InlineData(3, 5)]
        [InlineData(7, 17)]
        [InlineData(10, 29)]
        [InlineData(14, 43)]
        [InlineData(18, 61)]
        [InlineData(21, 73)]

        public void TestAllTheThings(int userInput, int expected)
        {
            int result = PrimeCheck.GetPrime(userInput);
            Assert.Equal(expected, result);
        }
    }
}