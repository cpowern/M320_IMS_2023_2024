using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIDL
{
    public class Lagerist: Person
    {
        public int Groese { get; set; }

        public void LagereEin()
        {
            Console.WriteLine($"Lagerist: {Vorname} {Name}");
        }
    }
}
