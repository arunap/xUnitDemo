using Xunit;
using xUnitTestDemo.Contracts;
using xUnitTestDemo.Services;
using xUnitTestDemo.Tests.Mock;

namespace xUnitTestDemo.Tests.TestMethods
{
    public class AddMethodTest
    {
        private readonly ICalculatorService _calculatorService;

        public AddMethodTest()
        {
            _calculatorService =  new CalculatorService();
        }

        [Fact]
        public void Add_ShouldReturnAdditionOfGivenValues()
        {
            // Arrange
            int expected = 10;

            // Act
            var actual = _calculatorService.Add(5, 5);

            // Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_MinusValuesShouldReturnMinusValues()
        {
            // Arrange
            int expected = -10;

            // Act
            var actual = _calculatorService.Add(-5, -5);

            // Assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(10, 11, 21)]
        [InlineData(99, 1, 100)]
        [InlineData(-50, -49, -99)]
        [InlineData(-5, -10, -15)]
        public void Add_Theory(int x, int y, int expected)
        {
            // Act
            var actual = _calculatorService.Add(x, y);

            // Assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(AddMethodData))]
        public void Add_NumbersWithClassData(int x, int y, int expected)
        {
            // Act
            var actual = _calculatorService.Add(x, y);

            // Assert 
            Assert.Equal(expected, actual);
        }
    }
}
