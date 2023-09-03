using System;

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(5, 7);

        // Überprüfen Sie die Werte im Debugger oder geben Sie sie aus
        Console.WriteLine($"Area: {rect.Area}");
        Console.WriteLine($"IsSquare: {rect.IsSquare}");
    }
}
