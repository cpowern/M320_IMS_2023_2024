namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Willkommen zum Calculator");
            Console.WriteLine("-------------------------");

            Methods Methods = new Methods();
            Methods.LastResult = 0;
            int choice = 0;

            while (true)
            {
                if (Methods.LastResult== 0)
                {
                    Methods.Menu();
                    choice = int.Parse(Console.ReadLine());

                    if(choice == 5)
                    {
                        Console.WriteLine("Das Programm wird beendet ...");
                        break;
                    }

                    Console.WriteLine("\nGeben Sie die erste Zahl ein");
                    int number1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nGeben sie die zweite Zahl ein");
                    int number2 = int.Parse(Console.ReadLine());

                    int result = 0;

                    switch (choice)
                    {
                        case 1:
                            result = Methods.Addition(number1, number2);
                            Console.WriteLine($"\nErgebnis: {result}\n");
                            break;

                        case 2:
                            result = Methods.Subtraktion(number1, number2);
                            Console.WriteLine($"\nErgebnis: {result}\n");
                            break;

                        case 3:
                            result = Methods.Multipilation(number1, number2);
                            Console.WriteLine($"\nErgebnis: {result}\n");
                            break;

                        case 4:
                            result = Methods.GanzZahlDivision(number1, number2);
                            Console.WriteLine($"\nErgebnis: {result}\n");
                            break;

                        case 5:
                            break;

                        default:
                            Console.WriteLine("\nUngültige Asuwahl.");
                            continue;
                    }

                    Methods.LastResult= result;
                    break;
                }

            }
        }

    }
}