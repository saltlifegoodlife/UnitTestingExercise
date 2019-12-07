using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3,-3, 3, 3)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(-5, -5, 1, -9)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Add(num1, num2, num3);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(-5, 5, -10)]
        [InlineData(30, 10, 20)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(4, 4, 16)]
        [InlineData(10, 10, 100)]
        [InlineData(3, 7, 21)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(4, 2 , 2)]
        [InlineData(22, 11, 2)]
        [InlineData(144, 12, 12)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();

            //Act
            int actual = challenger.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void GetHey()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.GetHey();
            //Assert
            Assert.Equal("HEY!", actual);
        }

        [Fact]
        public void GetHello()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.GetHello();
            //Assert
            Assert.Equal("Hello There!", actual);
        }
    }
}
