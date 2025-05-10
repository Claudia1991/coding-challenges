using Services;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace ServicesTests
{
    public class CalculatorServiceTests
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorServiceTests()
        {
            _calculatorService = new CalculatorService();
        }

        #region Addition
        [Fact]
        public void Add_GivenNullParameters_WhenAddIsCalled_ThenReturnException()
        {
            ///Arrange
            int? valueOne = null;
            int? valueTwo = null;

            ///ACT
           
            ///Assert
            Assert.Throws<InvalidOperationException>(() => _calculatorService.Add(valueOne, valueTwo));
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(-1,3,2)]
        [InlineData(2,-3,-1)]
        public void Add_GivenCorrectParameters_WhenAddIsCalled_ThenReturnCorrectResult(int? valueOne, int? valueTwo, int expectedValue)
        {
            ///Arange

            ///Act
            var expectedResult = _calculatorService.Add(valueOne, valueTwo);
            ///Assert
            Assert.Equal(expectedValue, expectedResult);
        }
        #endregion

        #region Subtraction
        [Fact]
        public void Substract_GivenNullParameters_WhenSubstractIsCalled_ThenReturnException()
        {
            ///Arrange
            int? valueOne = null;
            int? valueTwo = null;

            ///ACT

            ///Assert
            Assert.Throws<InvalidOperationException>(() => _calculatorService.Substract(valueOne, valueTwo));
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 3, -4)]
        [InlineData(2, -3, 5)]
        public void Substract_GivenCorrectParameters_WhenSubstractIsCalled_ThenReturnCorrectResult(int? valueOne, int? valueTwo, int expectedValue)
        {
            ///Arange

            ///Act
            var expectedResult = _calculatorService.Substract(valueOne, valueTwo);
            ///Assert
            Assert.Equal(expectedValue, expectedResult);
        }
        #endregion

        #region Division
        [Fact]
        public void Divide_GivenNullParameters_WhenDivideIsCalled_ThenReturnException()
        {
            ///Arrange
            int? valueOne = null;
            int? valueTwo = null;

            ///ACT

            ///Assert
            Assert.Throws<InvalidOperationException>(() => _calculatorService.Divide(valueOne, valueTwo));
        }

        [Fact]
        public void Divide_GivenZeroSecondParameter_WhenDivideIsCalled_ThenReturnException()
        {
            ///Arrange
            int? valueOne = 1;
            int? valueTwo = 0;

            ///ACT

            ///Assert
            Assert.Throws<DivideByZeroException>(() => _calculatorService.Divide(valueOne, valueTwo));
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, -2, -1)]
        public void Divide_GivenCorrectParameters_WhenDivideIsCalled_ThenReturnCorrectResult(int? valueOne, int? valueTwo, int expectedValue)
        {
            ///Arange

            ///Act
            var expectedResult = _calculatorService.Divide(valueOne, valueTwo);
            ///Assert
            Assert.Equal(expectedValue, expectedResult);
        }
        #endregion

        #region Multiplication
        [Fact]
        public void Multiply_GivenNullParameters_WhenMultiplyIsCalled_ThenReturnException()
        {
            ///Arrange
            int? valueOne = null;
            int? valueTwo = null;

            ///ACT

            ///Assert
            Assert.Throws<InvalidOperationException>(() => _calculatorService.Multiply(valueOne, valueTwo));
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(-1, 3, -3)]
        [InlineData(2, -3, -6)]
        public void Multiply_GivenCorrectParameters_WhenMultiplyIsCalled_ThenReturnCorrectResult(int? valueOne, int? valueTwo, int expectedValue)
        {
            ///Arange

            ///Act
            var expectedResult = _calculatorService.Multiply(valueOne, valueTwo);
            ///Assert
            Assert.Equal(expectedValue, expectedResult);
        }
        #endregion
    }
}