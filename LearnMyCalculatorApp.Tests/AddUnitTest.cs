using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class AddUnitTest
    {

    [TestMethod]
        public void AddTest()

        {
                // Arrange
                var calculator = new Calculator();

                // Act
                var actual = calculator.Add(1, 1);

                // Assert
                Assert.AreEqual(2, actual);
         }
    }

}
