namespace NumberConverter.Tests
{
    [TestClass]
    public class NumberConverterTest
    {
        [TestMethod]
        public void RoundUpTest()
        {
            // Arrange
            float valueToRoundUp = 12.3f;
            int expectedValue = 13;
            NumberConverter nc = new NumberConverter();

            // Act
            int actualValue = nc.RoundUp(valueToRoundUp);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod("Runden von ganzen Zahlen")]
        public void RoundUpWholeNumberTest()
        {
            // Arrange
            float valueToRoundUp = 15;
            int expectedValue = 15;
            NumberConverter nc = new NumberConverter();

            // Act
            int actualValue = nc.RoundUp(valueToRoundUp);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [DataTestMethod]
        [DataRow(12.5f, 13)]
        [DataRow(16, 16)]
        [DataRow(0, 0)]
        [DataRow(-18.2f, -18)]
        [DataRow(-20, -20)]
        public void RoundUpWithParametersTest(float valueToRoundUp, int expectedValue)
        {
            // Arrange
            NumberConverter nc = new NumberConverter();

            // Act
            int actualValue = nc.RoundUp(valueToRoundUp);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod()]
        public void RoundDownTest()
        {
            // Arrange
            float valueToRoundDown = 18;
            int expectedValue = 18;
            NumberConverter nc = new NumberConverter();

            // Act
            int actualValue = nc.RoundDown(valueToRoundDown);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [DataTestMethod]
        [DynamicData(nameof(GenerateTestData), DynamicDataSourceType.Method)]
        public void RoundToPowerOfTenTest(
            float numberToRound,
            int precisionExponent,
            NumberConverter nc,
            int expectedValue
            )
        {
            // Arrange
            // -

            // Act
            int actualValue = nc.RoundToPowerOfTen(numberToRound, precisionExponent);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        public static IEnumerable<object[]> GenerateTestData()
        {
            yield return new object[] { 12345, 1, new NumberConverter(), 12350 };
            yield return new object[] { 12345, 2, new NumberConverter(), 12300 };
            yield return new object[] { -12345, 1, new NumberConverter(), -12340 };
        }
    }
}