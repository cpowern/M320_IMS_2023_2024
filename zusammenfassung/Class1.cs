using System;

class Program
{
    static void Main()
    {
        // Benutzereingabe von der Konsole lesen

        // Benutzer wird aufgefordert, ihren Namen einzugeben
        Console.Write("Geben Sie Ihren Namen ein: ");
        // Die eingegebene Zeichenfolge wird in der Variablen "name" gespeichert
        string name = Console.ReadLine();

        // Benutzer wird aufgefordert, ihr Alter einzugeben
        Console.Write("Geben Sie Ihr Alter ein: ");
        // Die eingegebene Zeichenfolge wird in der Variablen "alter" gespeichert
        int alter = Convert.ToInt32(Console.ReadLine());

        // Daten formatiert auf der Konsole ausgeben

        // Eine leere Zeile für bessere Lesbarkeit
        Console.WriteLine("\nVielen Dank für die Eingabe!");
        Console.WriteLine("Ihre Informationen:");
        // Die Benutzereingaben werden formatiert auf der Konsole ausgegeben
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Alter: {alter} Jahre");

        // Beispiel für eine Formatierungsoption: Datum und Uhrzeit ausgeben

        // Die aktuelle Uhrzeit wird erfasst
        DateTime currentTime = DateTime.Now;
        // Die Uhrzeit wird formatiert auf der Konsole ausgegeben (Stunden, Minuten, Sekunden)
        Console.WriteLine($"\nAktuelle Uhrzeit: {currentTime:HH:mm:ss}");

        // Warten, bis der Benutzer eine Taste drückt, um das Programm zu beenden

        // Eine Zeile wird ausgegeben, um den Benutzer aufzufordern, eine Taste zu drücken
        Console.WriteLine("\nDrücken Sie eine beliebige Taste, um das Programm zu beenden...");
        // Das Programm wird angehalten und wartet auf eine Benutzereingabe, bevor es beendet wird
        Console.ReadKey();
    }
}
