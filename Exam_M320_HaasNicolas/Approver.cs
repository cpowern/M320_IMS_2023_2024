using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_M320_HaasNicolas
{
    public abstract class Approver
    {
        protected Approver successor;
        protected ConsoleLogger logger;
        public string name;        
        public Approver()
        {

        }


        public Approver(Approver successor)
        {
            
        }

        public abstract Approver ProcessRequest(Purchase purchase); 

    }

}
