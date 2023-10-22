using System;

class Program
{
    static void Main()
    {
        // Erstellen eines Wassertanks mit einem Anfangswasserstand von 0 Litern
        Wassertank tank = new Wassertank();

        // Befüllen des Tanks mit 50 Litern Wasser
        tank.befüllen(50);

        // Entnehmen von 20 Litern Wasser
        tank.entnehmen(20);

        // Den Tank entleeren
        tank.entleeren();

        // Den aktuellen Wasserstand ausgeben
        Console.WriteLine("Aktueller Wasserstand im Tank: " + tank.Wasserstand + " Liter");
    }
}
