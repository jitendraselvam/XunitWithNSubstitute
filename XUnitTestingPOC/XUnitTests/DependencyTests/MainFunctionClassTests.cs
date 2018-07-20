using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using Xunit;
using XUnitTestingPOC.DependencyInjectionFunctions;
using XUnitTestingPOC.DependencyInjectionFunctions.Interfaces;

namespace XUnitTests.DependencyTests
{
    public class MainFunctionClassTests
    {
        private readonly ISomeFunctions _someFunctions;
        private readonly MainFunctionClass sut;
        public MainFunctionClassTests()
        {
            _someFunctions = Substitute.For<ISomeFunctions>();  //Mocking SomeFunction dependency

            sut = new MainFunctionClass(_someFunctions);    //Resolving dependency
        }

        [Fact]
        public void GreaterThan5_whenInputsNonZero_ReturnsTrue()
        {
            //Arrange
            _someFunctions.AddFunction(Arg.Any<int>(), Arg.Any<int>()).Returns(10); //Mocking dependency class to return 10 for any int inputs

            //Action
            var result = sut.GreaterThan5(5, 6);    //inputs are useless as we are mocking the dependency method to return 10

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void GreaterThan5_whenInputsGreaterThan5_ReturnsTrue()
        {
            //Arrange
            _someFunctions.AddFunction(Arg.Any<int>(), Arg.Any<int>()).Returns(15); //Mocking dependency class to return 15 for any int inputs

            //Action
            var result = sut.GreaterThan5(10, 10);    //inputs are useless as we are mocking the dependency method to return 15

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void GreaterThan5_whenInputsLesserThan5_ReturnsFalse()
        {
            //Arrange
            _someFunctions.AddFunction(Arg.Any<int>(), Arg.Any<int>()).Returns(2); //Mocking dependency class to return 2 for any int inputs

            //Action
            var result = sut.GreaterThan5(10, 10);    //inputs are useless as we are mocking the dependency method to return 2

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void GreaterThan5_whenInputsAreZero_ReturnsFalse()
        {
            //Action
            var result = sut.GreaterThan5(0, 0);    //passing actual inputs

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void CompareReturnYesOrNo_WhenInputsEqual_returnsYes()
        {
            //Arrange
            _someFunctions.CompareTwoStrings(Arg.Any<string>(), Arg.Any<string>()).Returns(true); //Mocking dependency class to return true for any string inputs

            //Action
            var result = sut.CompareReturnYesOrNo("somestring", "somestring");    //inputs are useless as we are mocking the dependency method to return true

            //Assert
            Assert.NotNull(result);
            Assert.Equal("Yes", result);
        }

        [Fact]
        public void CompareReturnYesOrNo_WhenInputsNotEqual_returnsNo()
        {
            //Arrange
            _someFunctions.CompareTwoStrings(Arg.Any<string>(), Arg.Any<string>()).Returns(false); //Mocking dependency class to return false for any string inputs

            //Action
            var result = sut.CompareReturnYesOrNo("somestring", "somestring");    //inputs are useless as we are mocking the dependency method to return true

            //Assert
            Assert.NotNull(result);
            Assert.Equal("No", result);
        }

        [Fact]
        public void CompareReturnYesOrNo_WhenInputsNullOrEmpty_returnsNull()
        {
            //Action
            var result = sut.CompareReturnYesOrNo(null, "somestring");    //passing actual inputs

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void AddElementsToList_IfListGeneratedIsNull_ReturnsEmptyList()
        {
            //Arrange
            _someFunctions.GenerateList().Returns((List<int>)null); //Mocking dependency class to return a null object (requiers you to specify the type of return object)

            //Action
            var result = sut.AddElementsToList();

            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void AddElementsToList_IfListGenerated_ReturnsListWithCertainElements()
        {
            //Arrange
            _someFunctions.GenerateList().Returns(new List<int>()); //Mocking dependency class to return a new list

            //Action
            var result = sut.AddElementsToList();

            Assert.NotNull(result);
            Assert.Collection(result,
                item => Assert.Equal(1,item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item)
                );
        }
    }
}
