using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsOperationDemo;
using Xunit;

namespace MathsOperations.Tests
{
    public class MathsOperationsTests
    {
        [Theory]
        [InlineData(4.0,2.0,6.0)]
        public void AddShouldReturnExpectedValue(double num1, double num2, double expected)
        {
            // Arrange
            MathOperation calculate = new MathOperation();

            // Act
            double actual = calculate.Add(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4.0, 2.0, 2.0)]
        public void SubtractShouldReturnExpectedValue(double num1, double num2, double expected)
        {
            // Arrange
            MathOperation calculate = new MathOperation();

            // Act
            double actual = calculate.Subtract(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4.0, 2.0, 8.0)]
        public void MultiplyShouldReturnExpectedValue(double num1, double num2, double expected)
        {
            // Arrange
            MathOperation calculate = new MathOperation();

            // Act
            double actual = calculate.Multiply(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12.0, 2.0, 6.0)]
        [InlineData(12, 0, 0)]
        public void DivideShouldReturnExpectedValue(double num1, double num2, double expected)
        {
            // Arrange
            MathOperation calculate = new MathOperation();

            // Act
            double actual = calculate.Divide(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
