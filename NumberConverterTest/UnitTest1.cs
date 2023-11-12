using NumberConverter;

namespace NumberConverterTest;

[TestClass]
public class NumberConverterTest
{
    private NumberConverter _numberConverter;

    [TestInitialize]
    public void Initialize()
    {
        _numberConverter = new NumberConverter();
    }

    [TestMethod]
    public void TestRoundUp()
    {
        // Arrange
        float value = 2.3f;
        int expected = 3;

        // Act
        int actual = _numberConverter.RoundUp(value);

        // Assert
        Assert.AreEqual(expected, actual, "RoundUp method did not produce the expected result.");
    }

    [TestMethod]
    public void TestRoundDown()
    {
        // Arrange
        float value = 2.3f;
        int expected = 2;

        // Act
        int actual = _numberConverter.RoundDown(value);

        // Assert
        Assert.AreEqual(expected, actual, "RoundDown method did not produce the expected result.");
    }

    [TestMethod]
    public void TestRoundToPowerOfTen()
    {
        // Arrange
        float value = 118.9f;
        int precisionExponent = 1;
        int expected = 120;

        // Act
        int actual = _numberConverter.RoundToPowerOfTen(value, precisionExponent);

        // Assert
        Assert.AreEqual(expected, actual, "RoundToPowerOfTen method did not produce the expected result.");
    }
}