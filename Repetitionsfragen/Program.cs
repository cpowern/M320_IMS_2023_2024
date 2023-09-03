namespace Repetitionsaufgaben_280823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;
            int[] array = { 200, 450, 700, 175, 250 };
            foreach (int zahl in array)
            {
                summe += zahl;
            }
            Console.WriteLine(summe);



        }
    }
}