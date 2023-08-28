using System;

class Programm
{
    static void Main()
    {
        while (true)
        {
            MenuAnzeigen(); // Abfrage

            int auswahl = GanzeZahlEinlesen();

            switch (auswahl)
            {
                case 1:
                    GGTBerechnen();
                    break;
                case 2:
                    KGVBerechnen();
                    break;
                case 3:
                    MittelwerteMinUndMaxBerechnen();
                    break;
                case 4:
                    VariablenTausch();
                    break;
                case 5:
                    ArrayUmdrehen();
                    break;
                case 6:
                    ArraySortieren();
                    break;
                case 7:
                    return; // Beenden
                case 8: // Neue Option für den rekursiven ggT
                    GGTRekursivBerechnen();
                    break;
                default:
                    Console.WriteLine("Ungültige Option. Bitte wählen Sie erneut.");
                    break;
            }
        }
    }



    static void MenuAnzeigen()
    {
        Console.WriteLine("Bitte wählen Sie eine Option:");
        Console.WriteLine("1. GGT berechnen");
        Console.WriteLine("2. KGV berechnen");
        Console.WriteLine("3. Mittelwerte, Min und Max ermitteln");
        Console.WriteLine("4. Variablen tauschen");
        Console.WriteLine("5. Array umdrehen");
        Console.WriteLine("6. Array sortieren");
        Console.WriteLine("7. GGT rekursiv berechnen"); // Neue Option für den rekursiven ggT
        Console.WriteLine("8. Beenden");
        
    }


    static void GGTBerechnen()
    {
        int zahl1 = GanzeZahlEinlesen();
        int zahl2 = GanzeZahlEinlesen();
        int ggt = GGTBerechnen(zahl1, zahl2);
        ErgebnisAnzeigen("GGT", zahl1, zahl2, ggt);
    }

    static void KGVBerechnen()
    {
        int zahl1 = GanzeZahlEinlesen();
        int zahl2 = GanzeZahlEinlesen();
        int kgv = KGVBerechnen(zahl1, zahl2);
        ErgebnisAnzeigen("KGV", zahl1, zahl2, kgv);
    }

    static void MittelwerteMinUndMaxBerechnen()
    {
        int[] zahlen = ZahlenEinlesen();
        double mittelwert = MittelwertBerechnen(zahlen);
        int minimum = MinimumFinden(zahlen);
        int maximum = MaximumFinden(zahlen);
        Console.WriteLine($"Mittelwert: {mittelwert}");
        Console.WriteLine($"Minimum: {minimum}");
        Console.WriteLine($"Maximum: {maximum}");
    }

    static void VariablenTausch()
    {
        int x = GanzeZahlEinlesen();
        int y = GanzeZahlEinlesen();
        Tauschen(ref x, ref y);
        Console.WriteLine($"Nach dem Tausch: x = {x}, y = {y}");
    }

    static void ArrayUmdrehen()
    {
        int[] zahlen = ZahlenEinlesen();
        ArrayUmdrehen(zahlen);
        Console.WriteLine("Array umgedreht: " + string.Join(" ", zahlen));
    }

    static void ArraySortieren()
    {
        int[] zahlen = ZahlenEinlesen();
        ArraySortieren(zahlen);
        Console.WriteLine("Array sortiert: " + string.Join(" ", zahlen));
    }

    static int Calc_ggT_r(int a, int b)
    {
        if (b == 0)
            return a;
        return Calc_ggT_r(b, a % b);
    }

    static void GGTBerechnen()
    {
        int zahl1 = GanzeZahlEinlesen();
        int zahl2 = GanzeZahlEinlesen();
        int ggt = Calc_ggT_r(zahl1, zahl2); // Hier verwenden wir die rekursive Methode
        ErgebnisAnzeigen("GGT (rekursiv)", zahl1, zahl2, ggt);
    }



    // ... (die vorherigen Hilfsfunktionen bleiben unverändert) ...
}
