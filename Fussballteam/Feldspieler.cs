using System;

namespace MyNamespace
{
    public class Feldspieler
    {
        public void AufsTorSchiessen(string name)
        {
            Console.WriteLine($"{name} schießt aufs Tor");
        }

        public void Graetschen(string name)
        {
            Console.WriteLine($"{name} macht eine Blutgrätsche");
        }

        public void Dribbeln(string name)
        {
            Console.WriteLine($"{name} dribbelt den Gegner schwindlig");
        }

        public void TorSchiessen(string name)
        {
            Console.WriteLine($"{name} schießt ein Tor");
        }
    }
}
