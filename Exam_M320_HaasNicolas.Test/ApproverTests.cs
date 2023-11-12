using Exam_M320_HaasNicolas;

namespace Exam_M320.Tests
{
    [TestClass]
    public class ApproverTests
    {
        public double quantity;
        public double ampount;
        public float taxRate;

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            //ich habe hier genau das gleiche Problem ich kann die 3 werte in Purchase nicht benutzten
            Purchase supplies = new Purchase();
            Purchase projectOne = new Purchase();
            Purchase projectArtemis = new Purchase(); 

            supplies = new Purchase(3, 350.00, 77);
            projectOne = new Purchase(1, 15000, 0);
            projectArtemis = new Purchase(1, 100000, 24);

            // Act
            var actual = supplies;
            var actual2 = projectOne;
            var actual3 = projectArtemis;


            // Assert
            Assert.AreEqual(3, 350.00, "77", actual);
            Assert.AreEqual(1, 15000.00, "0", actual2);
            Assert.AreEqual(3, 100000, "24", actual3);
        }
    }
}