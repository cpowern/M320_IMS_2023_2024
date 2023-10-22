using System;

class Program
{
    static void Main()
    {
        // Primitiver Datentyp: Integer-Array erstellen und initialisieren
        int[] myArray = { 10, 20, 30, 40, 50 };

        // Array-Elemente ausgeben
        Console.WriteLine("Array-Elemente:");
        foreach (int num in myArray)
        {
            Console.WriteLine(num);
        }

        // Wertetypen und Referenztypen unterscheiden
        int x = 10; // Wertetyp
        int[] y = { 1, 2, 3 }; // Referenztyp (Array)

        // Enum verwenden
        Days today = Days.Wednesday;
        Console.WriteLine($"\nHeute ist: {today}");

        // Klasse (class) erstellen und verwenden
        Person person = new Person("Max", 30);
        Console.WriteLine($"\nPerson: {person.Name}, {person.Age} Jahre alt");

        // Schnittstelle (interface) verwenden
        ILogger logger = new ConsoleLogger();
        logger.Log("Eine Log-Nachricht");
    }
}

// Enum definieren
enum Days { Monday, Tuesday, Wednesday, Thursday, Friday }

// Klasse (class) definieren
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Schnittstelle (interface) definieren
interface ILogger
{
    void Log(string message);
}

// Schnittstellenimplementierung
class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}


//Iteration und Selektion

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} ist eine gerade Zahl.");
    }
    else
    {
        Console.WriteLine($"{number} ist eine ungerade Zahl.");
    }
}


void ModifyValue(int x)
{
    x = x + 10;
}

int number = 5;
ModifyValue(number); // Hier wird eine Kopie von "number" übergeben
Console.WriteLine(number); // Dies gibt 5 aus, da "number" nicht geändert wird


