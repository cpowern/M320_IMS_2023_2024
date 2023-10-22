using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dings
{
    internal class Hund
    {
        private List<Laus> lause = new List<Laus>();

        public void AddLaus(Laus laus)
        {
            lause.Add(laus);

        }
    }
}
