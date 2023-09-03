using System;

class Programm
{
    static void Main(string[] args)
    {
        Taschenrechner taschenrechner = new Taschenrechner();
        TaschenrechnerAusführen(taschenrechner);
    }

    static void TaschenrechnerAusführen(Taschenrechner taschenrechner)  // Anzeige
    {
        Console.WriteLine("Einfacher Taschenrechner");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Beenden");

        char option;
        do
        {
            Console.Write("Wählen Sie eine Option (1/2/3/4/5): ");
            option = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (option >= '1' && option <= '4')         // Consolenabfrage
            {
                Console.Write("Geben Sie die erste Zahl ein: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geben Sie die zweite Zahl ein: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());

                int ergebnis = 0;

                switch (option)         // Switchcase für den Taschenrechner
                {
                    case '1':
                        ergebnis = taschenrechner.Addition(zahl1, zahl2);
                        break;
                    case '2':
                        ergebnis = taschenrechner.Subtraktion(zahl1, zahl2);
                        break;
                    case '3':
                        ergebnis = taschenrechner.Multiplikation(zahl1, zahl2);
                        break;
                    case '4':
                        ergebnis = taschenrechner.Division(zahl1, zahl2);
                        break;
                }

                Console.WriteLine("Ergebnis: " + ergebnis);         //Ergebnis Anzeigen lassen
            }
            else if (option == '5')
            {
                Console.WriteLine("Das Programm wird beendet.");
            }
            else
            {
                Console.WriteLine("Ungültige Option. Bitte wählen Sie erneut.");
            }

        } while (option != '5');
    }
}
