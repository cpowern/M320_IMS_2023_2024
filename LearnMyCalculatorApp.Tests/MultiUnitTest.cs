using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class MultiUnitTest
    {

        [TestMethod]
        public void MultiplyTest()

        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(2, 2);

            // Assert
            Assert.AreEqual(4, actual);
        }
    }

}
