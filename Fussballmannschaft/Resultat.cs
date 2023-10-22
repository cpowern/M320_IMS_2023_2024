using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    public class Resultat
    {
        // Assoziation zum Spiel
        public Spiel Spiel { get; set; }
        public int HeimmannschaftTore { get; set; }
        public int GastmannschaftTore { get; set; }
    }
}

