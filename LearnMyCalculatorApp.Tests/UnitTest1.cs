using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;
namespace LearnMyCalculatorApp.Tests

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }
    }
}