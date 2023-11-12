using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exam_M320_HaasNicolas
{
    public class Purchase
    {
        private int id;
        private int lastId;
        public string purpose;
        public int quantity { get; }
        public double amount { get; }
        public float taxRate { get; }
        protected double totalAmound;
        protected double totalAmountGros;

        public Purchase (int quantity, double amount, float taxRate)
        {
            quantity = 0;
            amount = 0;
            taxRate = 0;
        }

        public Purchase()
        {
        }
    }
}
