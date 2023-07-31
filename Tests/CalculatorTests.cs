using NUnit.Framework;
using System;
using Unit_testing.Models;

namespace Unit_testing.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            var Calculator = new Calculator();

            // Act
            int result = Calculator.Add(5, 10);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Subtract_ShouldReturndifferenceOfTwoNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Subtract(10, 5);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}