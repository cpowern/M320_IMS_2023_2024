using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_M320_HaasNicolas
{
    public class VicePresident : Approver
    {
        public override Approver ProcessRequest(Purchase purchase)
        {
            Console.WriteLine("Project One von John bearbeitet");
            return this;
        }
    }
}
