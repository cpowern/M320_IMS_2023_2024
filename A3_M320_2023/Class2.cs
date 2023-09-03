
class Calculator
{
    private int lastResult = 0; // Interner Zustand zur Speicherung des letzten Ergebnisses

    public int Add(int operand1, int operand2)
    {
        lastResult = operand1 + operand2;
        return lastResult;
    }

    public int Subtract(int operand1, int operand2)
    {
        lastResult = operand1 - operand2;
        return lastResult;
    }

    public int Multiply(int operand1, int operand2)
    {
        lastResult = operand1 * operand2;
        return lastResult;
    }

    public int Divide(int operand1, int operand2)
    {
        if (operand2 == 0)
        {
            Console.WriteLine("Division durch Null ist nicht erlaubt.");
            return lastResult;
        }

        lastResult = operand1 / operand2;
        return lastResult;
    }
}
