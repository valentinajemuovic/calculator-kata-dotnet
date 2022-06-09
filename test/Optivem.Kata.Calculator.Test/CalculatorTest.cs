using FluentAssertions;
using Xunit;

namespace Optivem.Kata.Calculator.Test
{
    public class CalculatorTest
    {
        private readonly Core.Calculator calculator;

        public CalculatorTest()
        {
            this.calculator = new Core.Calculator();
        }

        [Fact]
        public void Should_add_two_numbers()
        {
            var first = 2;
            var second = 3;

            var expectedResult = 5;

            var result = calculator.Add(first, second);

            result.Should().Be(expectedResult);
        }
    }
}