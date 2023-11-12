namespace BrowserSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erstellen Sie eine Instanz des Simulators
            Simulator simulator = new Simulator();
            simulator.Run();

            // Erstellen Sie eine Instanz der StringStack-Klasse
            StringStack stringStack = new StringStack(10);

            // Fügen Sie einige Werte zum Stack hinzu
            stringStack.Push("Startseite");
            stringStack.Push("URL1");
            stringStack.Push("URL2");

            // Geben Sie den aktuellen Zustand des Stacks aus
            Console.WriteLine($"Aktuelle Seite: {stringStack.Peak()}, IstVoll: {stringStack.IsFull}");

            // Klicken Sie auf einen Link und gehen Sie vorwärts
            stringStack.Push("Neue Seite");

            // Geben Sie den aktualisierten Zustand des Stacks aus
            Console.WriteLine($"Aktuelle Seite: {stringStack.Peak()}, IstVoll: {stringStack.IsFull}");

            // Gehen Sie zurück zur vorherigen Seite
            string previousPage = stringStack.Pop();
            Console.WriteLine($"Zurückgegangen zur Seite: {previousPage}");

            // Geben Sie den aktuellen Zustand des Stacks aus
            Console.WriteLine($"Aktuelle Seite: {stringStack.Peak()}, IstVoll: {stringStack.IsFull}");

            // Gehen Sie vorwärts zur neuen Seite
            stringStack.Push("Neueste Seite");

            // Geben Sie den aktualisierten Zustand des Stacks aus
            Console.WriteLine($"Aktuelle Seite: {stringStack.Peak()}, IstVoll: {stringStack.IsFull}");
        }
    }
}
