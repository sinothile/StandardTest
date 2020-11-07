using NUnit.Framework;
using Section2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Calculator_should_return_sum_of_multiples()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.calculateSumOfMultiples();

            //Assert
            var expected = 233168;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Calculator_should_return_10001_prime()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.get1001Prime();

            //Assert
            var expected = 233168;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Calculator_should_return_fibonacci_terms()
        {
            //Arrange
            var calculator = new Calculator();  

            //Act
            var actual = calculator.sumOfEvenFibonacciTerms(10);

            //Assert
            var expected = 44;
            Assert.AreEqual(actual, expected);
        }
    }
}
