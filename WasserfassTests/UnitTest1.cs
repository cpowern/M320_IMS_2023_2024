using System.Security.Cryptography.X509Certificates;

namespace WasserfassTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Wasserfass wasserfass = new Wasserfass(0, 100); 

            // Act
            wasserfass.Befüllen(30); 

            // Assert
            Assert.AreEqual(30, wasserfass.fuellstand);

            // Arrange
            Wasserfass wasserfass = new Wasserfass(0, 100, 50, 1000);

            // Act
            wasserfass.Befüllen(120);

            // Assert
            Assert.AreEqual(100, wasserfass.fuellstand); 
        }
    }
}