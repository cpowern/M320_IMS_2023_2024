namespace LIDL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var person1 = new Person() { Vorname = "Max", Name = "Mustermann" };
            var kunde1 = new Kunde() { Vorname = "Fritz", Name = "Müller", Umsatz = 1000 };
            var lagerist = new Lagerist() { Vorname = "Hans", Name = "Meier", Groese= 1000 };

            //person1.Esse();

        }
    }
}