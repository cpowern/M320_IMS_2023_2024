namespace InversionOfControlTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 2;
            int b = 3;
            int expectedResult = 5;

            //Act
            int result = a + b;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}