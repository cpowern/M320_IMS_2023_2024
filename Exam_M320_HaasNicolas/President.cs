using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_M320_HaasNicolas
{
    public class President : Approver
    {
        public override Approver ProcessRequest(Purchase purchase)
        {
            Console.WriteLine("Project Artemis kann nicht bearbeitet werden");
            return this;
        }
    }
}
