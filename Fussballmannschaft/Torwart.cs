using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MyNamespace
{
    public class Torwart
    {
        public void Abstoss()
        {
            Console.WriteLine("Torwart macht einen Abstoss!");
        }

        public void SchussHalten(string name)
        {
            Console.WriteLine($"{name} hält den Schuss vom Gegner!");
        }
    }
}

