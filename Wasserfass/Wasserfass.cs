using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    public class Wasserfass
    {
        private int minimalPegel { get; }
        private int maximalPegel { get; }
        public int fuellstand { get; set; }
        public int Kapazität { get; }
        public Wasserfass (int fuellstand , int Kapazität)
        {
            fuellstand = 0;
            Kapazität = 100;
            Kapazität = fuellstand;
        }
        public void Befüllen(int menge)
        {
            if(fuellstand + menge <= Kapazität)
            {
                fuellstand += menge;
            }
            else
            {
                fuellstand = Kapazität;
            }
        }

        public void Entnehmen( int menge)
        {
            if(fuellstand - menge >= minimalPegel)
            {
                fuellstand -= menge;
            }
            else
            {
                fuellstand = minimalPegel;
            }
        }

        public void Entleeren(int menge)
        {
                fuellstand = maximalPegel;
        }

    }
}
