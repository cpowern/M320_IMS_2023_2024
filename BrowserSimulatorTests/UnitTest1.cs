using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrowserSimulator;

namespace BrowserSimulatorTests
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
            Assert.IsTrue(stack.IsFull); // Überprüft, ob der Stack voll ist
            Assert.AreEqual("URL3", stack.Peak()); // Überprüft, ob der zuletzt hinzugefügte Wert oben auf dem Stack ist
        }

        [TestMethod]
        public void TestPop()
            //Mit chatGPT gemacht, es geht nicht, ich verstehe das ganze nicht.
            //Ich bin schon seit Stunden dran und sogar die KI hat aufgegeben und gesagt ich soll es in ein anderes Projekt machen.
        {
            // Arrange
            StringStack stack = new StringStack(3);

            // Act
            stack.Push("URL1");
            stack.Push("URL2");
            stack.Push("URL3");

            // Print the state before pop
            Console.WriteLine($"Before Pop - Top of the stack: {stack.Peak()}, IsFull: {stack.IsFull}");

            string poppedValue = stack.Pop();

            // Print the state after pop
            Console.WriteLine($"After Pop - Popped value: {poppedValue}, Top of the stack: {stack.Peak()}, IsFull: {stack.IsFull}");

            // Assert
            Assert.AreEqual("URL2", poppedValue);
            Assert.AreEqual("URL2", stack.Peak());
            Assert.IsFalse(stack.IsFull);
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

            // Assert
            Assert.AreEqual("URL3", stack.Peak()); // Überprüft, ob der zuletzt hinzugefügte Wert oben auf dem Stack ist
            Assert.IsTrue(stack.IsFull); // Überprüft, ob der Stack voll ist
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
            Assert.IsTrue(stack.IsEmpty); // Überprüft, ob der Stack nach dem Löschen leer ist
        }

        // Weitere Tests für IsEmpty, Count, IsFull und andere Szenarien können hier hinzugefügt werden.
    }
}
