using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MyNamespace
{
    public class Feldspieler
    {
        public void AufsTorSchiessen(string name)
        {
            Console.WriteLine($"{name} schießt aufs Tor!");
        }

        public void Graetschen(string name)
        {
            Console.WriteLine($"{name} macht eine Blutgrätsche!");
        }

        public void Dribbeln(string name)
        {
            Console.WriteLine($"{name} dribbelt den Gegner schwindlig!");
        }
    }
}

