using System;

namespace MyNamespace
{
    public class Torwart
    {
        public void Abstoss()
        {
            Console.WriteLine("Torwart macht einen abstoss");
        }

        public void SchussHalten(string name)
        {
            Console.WriteLine($"{name} hält den Schuss vom Gegner");
        }
        
    }
}
