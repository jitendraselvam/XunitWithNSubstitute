using System;
using Xunit;
using XUnitTestingPOC.SimpleFunctions;
namespace XUnitTests

{
    public class SimpleFunctionTests
    {
        private readonly SimpleFunctions sut;

        public SimpleFunctionTests()
        {
            sut = new SimpleFunctions();
        }

        [Fact]
        public void PositiveIntegerAdditions_whenAllAreGreaterThanZero_ReturnsSum()
        {
            //Arrange
            int a = 5, b = 5;

            //Act
            var result = sut.PositiveIntegerAdditions(a, b);

            //Asert
            Assert.Equal(10, result);
        }

        [Fact]
        public void PositiveIntegerAdditions_whenOneLessThanZero_ReturnsNegOne()
        {
            //Arrange
            int a = -5, b = 5;

            //Act
            var result = sut.PositiveIntegerAdditions(a, b);

            //Asert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void PositiveIntegerAdditions_whenBothLessThanZero_ReturnsNegOne()
        {
            //Arrange
            int a = -5, b = -5;

            //Act
            var result = sut.PositiveIntegerAdditions(a, b);

            //Asert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void EvenOrOdd_whenNumberIsEven_ReturnsEven()
        {
            //Arrange
            int a = 6;

            //Act
            var result = sut.EvenOrOdd(a);

            //Asert
            Assert.Equal("Even", result);
        }

        [Fact]
        public void EvenOrOdd_whenNumberIsOdd_ReturnsOdd()
        {
            //Arrange
            int a = 5;

            //Act
            var result = sut.EvenOrOdd(a);

            //Asert
            Assert.Equal("Odd", result);
        }

        [Fact]
        public void EvenOrOdd_whenNumberIsZero_DoesNotReturnOddOrEven()
        {
            //Arrange
            int a = 0;

            //Act
            var result = sut.EvenOrOdd(a);

            //Asert
            Assert.DoesNotContain("Even",result);
            Assert.DoesNotContain("Odd", result);
        }

        [Fact]
        public void SimpleBoolFunction_WhenNumIsEven_ReturnsTrue()
        {
            //Arrange
            int a = 2;

            //Act
            var result = sut.SimpleBoolFunction(a);

            //Asert
            Assert.True(result);
        }

        [Fact]
        public void SimpleBoolFunction_WhenNumIsOdd_ReturnsFalse()
        {
            //Arrange
            int a = 3;

            //Act
            var result = sut.SimpleBoolFunction(a);

            //Asert
            Assert.False(result);
        }

        [Fact]
        public void SimpleNullFunction_WhenInputIsFalse_ReturnsNull()
        {
            //Arrange
            bool a = false;

            //Act
            var result = sut.SimpleNullFunction(a);

            //Assert
            Assert.Null(result);

        }

        [Fact]
        public void SimpleNullFunction_WhenInputIsTrue_ReturnsEmptyList()
        {
            //Arrange
            bool a = true;

            //Act
            var result = sut.SimpleNullFunction(a);

            //Assert
            Assert.NotNull(result);
            Assert.Empty(result);

        }
    }
}
