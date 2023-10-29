using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIDL
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }

        public void Esse()
        {
            Console.WriteLine($"Person: {Name} {Vorname}");
        }
    }
}
