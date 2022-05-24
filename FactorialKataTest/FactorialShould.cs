using FactorialKata;
using FluentAssertions;
using NUnit.Framework;

namespace FactorialKataTest
{
    public class FactorialShould
    {
        [Test]
        public void zero_factorial_should_return_one()
        {
            var result = Factorial.GetFactorial(0);
            
            result.Should().Be(1);
        }

        [Test]
        public void one_factorial_should_return_one()
        {
            var result = Factorial.GetFactorial(1);

            result.Should().Be(1);
        }

        [Test]
        public void two_factorial_should_return_two()
        {
            var result = Factorial.GetFactorial(2);

            result.Should().Be(2);
        }

        [Test]
        public void three_factorial_should_return_six()
        {
            var result = Factorial.GetFactorial(3);

            result.Should().Be(6);
        }
    }
}
