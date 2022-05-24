using FactorialKata;
using FluentAssertions;
using NUnit.Framework;

namespace FactorialKataTest
{
    public class FactorialShould
    {
        [Test]
        [TestCase(0,1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(8, 40320)]
        public void zero_factorial_should_return_one(int value, int expectedResult)
        {
            var result = Factorial.GetFactorial(value);
            
            result.Should().Be(expectedResult);
        }
    }
}
