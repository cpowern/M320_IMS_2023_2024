﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIDL
{
    public class Kunde : Person
    {
        public double Umsatz { get; set; } 

        public void kaufe()
        {
            Console.WriteLine($" Kunde: {Vorname} + {Name} ");
        }
    }
}
