using FactorialKata;
using FluentAssertions;
using NUnit.Framework;

namespace FactorialKataTest
{
    public class FactorialShould
    {
        [Test]
        public void Zero_factorial_should_return_1()
        {
            var result = Factorial.GetFactorial(0);
            
            result.Should().Be(1);
        }
    }
}
