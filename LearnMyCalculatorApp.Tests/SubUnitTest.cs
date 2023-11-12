using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class SubUnitTest
    {

        [TestMethod]
        public void DivideTest()

        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(8, 2);

            // Assert
            Assert.AreEqual(4, actual);
        }
    }

}
