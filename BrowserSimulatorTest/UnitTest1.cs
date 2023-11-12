using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BrowserSimulatorTest
{
    [TestClass]
    public class StringStackTest
    {
        [TestMethod]
        public void TestPush()
        {
            // Arrange
            StringStack stack = new StringStack(3);

            // Act
            stack.Push("URL1");
            stack.Push("URL2");
            stack.Push("URL3");

            // Assert
            Assert.AreEqual("URL3", stack.Peak()); // �berpr�ft, ob der zuletzt hinzugef�gte Wert oben auf dem Stack ist
            Assert.IsTrue(stack.IsFull); // �berpr�ft, ob der Stack voll ist
        }

        [TestMethod]
        public void TestPop()
        {
            // Arrange
            StringStack stack = new StringStack(3);

            // Act
            stack.Push("URL1");
            stack.Push("URL2");
            stack.Push("URL3");

            string poppedValue = stack.Pop();

            // Assert
            Assert.AreEqual("URL2", poppedValue); // �berpr�ft, ob der zuletzt entfernte Wert korrekt ist
            Assert.IsFalse(stack.IsFull); // �berpr�ft, ob der Stack nicht mehr voll ist
        }

        [TestMethod]
        public void TestPeak()
        {
            // Arrange
            StringStack stack = new StringStack(3);

            // Act
            stack.Push("URL1");
            stack.Push("URL2");
            stack.Push("URL3");

            string peekedValue = stack.Peak();

            // Assert
            Assert.AreEqual("URL3", peekedValue); // �berpr�ft, ob der zuletzt hinzugef�gte Wert oben auf dem Stack ist
            Assert.IsTrue(stack.IsFull); // �berpr�ft, ob der Stack voll ist
        }

        [TestMethod]
        public void TestClear()
        {
            // Arrange
            StringStack stack = new StringStack(3);

            // Act
            stack.Push("URL1");
            stack.Push("URL2");
            stack.Push("URL3");

            stack.Clear();

            // Assert
            Assert.IsTrue(stack.IsEmpty); // �berpr�ft, ob der Stack nach dem L�schen leer ist
        }

        // Weitere Tests f�r IsEmpty, Count, IsFull und andere Szenarien k�nnen hier hinzugef�gt werden.
    }
}
