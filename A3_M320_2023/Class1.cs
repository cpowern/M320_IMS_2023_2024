class Taschenrechner
{
    private int letztesErgebnis = 0; // Speicherung des letzten Ergebnisses

    public int Addition(int operand1, int operand2)
    {
        letztesErgebnis = operand1 + operand2;
        return letztesErgebnis;
    }

    public int Subtraktion(int operand1, int operand2)
    {
        letztesErgebnis = operand1 - operand2;
        return letztesErgebnis;
    }

    public int Multiplikation(int operand1, int operand2)
    {
        letztesErgebnis = operand1 * operand2;
        return letztesErgebnis;
    }

    public int Division(int operand1, int operand2)
    {
        if (operand2 == 0)
        {
            Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt.");
            return letztesErgebnis;
        }

        letztesErgebnis = operand1 / operand2;
        return letztesErgebnis;
    }
}
