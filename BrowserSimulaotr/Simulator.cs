using BrowserSimulator;

internal class Simulator
{
    // Erstellen Sie eine Instanz der StringStack-Klasse
    private StringStack stringStack = new StringStack(10);

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Geben Sie eine URL ein oder 'back' für zurück, 'forward' für vorwärts oder 'exit' zum Beenden.");
            string input = Console.ReadLine();

            if (input == "exit")
            {
                Console.WriteLine("Das Programm wird geschlossen.");
                break;
            }
            else if (input == "back")
            {
                // Gehen Sie zurück, wenn möglich
                string previousPage = stringStack.Pop();
                if (previousPage != null)
                {
                    Console.WriteLine($"Zurück zur Seite: {previousPage}");
                    BrowseURL(previousPage);
                }
                else
                {
                    Console.WriteLine("Es gibt keine vorherige Seite.");
                }
            }
            else if (input == "forward")
            {
                // Gehen Sie vorwärts, wenn möglich
                string nextPage = stringStack.Peak();
                if (nextPage != null)
                {
                    Console.WriteLine($"Vorwärts zur Seite: {nextPage}");
                    BrowseURL(nextPage);
                }
                else
                {
                    Console.WriteLine("Es gibt keine nächste Seite.");
                }
            }
            else
            {
                // Normale URL eingeben
                BrowseURL(input);
                // Aktuelle URL zum Stack hinzufügen
                stringStack.Push(input);
            }
        }
    }

    public void BrowseURL(string url)
    {
        Console.WriteLine($"Lade {url}");
    }
}
