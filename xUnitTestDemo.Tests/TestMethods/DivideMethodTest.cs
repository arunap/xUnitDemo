using Xunit;
using xUnitTestDemo.Contracts;
using xUnitTestDemo.Services;
using xUnitTestDemo.Tests.Mock;

namespace xUnitTestDemo.Tests.TestMethods
{
    public class DivideMethodTest
    {
        private readonly ICalculatorService _calculatorService;

        public DivideMethodTest()
        {
            _calculatorService = new CalculatorService();
        }

        [Fact]
        public void Divide_ShouldReturnZero_WhenDivideByZero()
        {
            // Arrange
            var expected = 0;

            // Actual

            var actual = _calculatorService.Divide(0, 0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_ShouldReturnPlusValue_WhenDividedByTwoMinusValues()
        {
            // Arrange
            var expected = 5;

            // Actual

            var actual = _calculatorService.Divide(-50, -10);

            // Assert
            Assert.Equal(expected, actual);
        }



        [Theory]
        [ClassData(typeof(DivideMethodData))]
        public void Divide_NumbersWithClassData(int x, int y, int expected)
        {
            // Act
            var actual = _calculatorService.Divide(x, y);

            // Assert 
            Assert.Equal(expected, actual);
        }
    }
}
