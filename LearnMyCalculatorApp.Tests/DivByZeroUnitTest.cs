using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class DivByZeroUnitTest
    {

        [TestMethod]
        public void DivByZeroTest()

        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(7, 0);

            // Assert
            Assert.IsNull(actual);
        }
    }

}
