namespace dings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Vater und Sohn
            Vater fritz = new Vater();
            Sohn hansli = new Sohn();
            fritz.SetSohn(hansli);
            hansli.SetVater(fritz);

            //Laus und Hund
            */

            Hund hund = new Hund();
            Laus laus = new Laus(hund);
            Laus laus2 = new Laus(hund);
            int i = 0;

        }
    }
}