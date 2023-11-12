using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Exam_M320_HaasNicolas
{
    public class Program
    {
        static void Main(string[] args)
        {
            President bill = new President();
            VicePresident john = new VicePresident();
            Director max= new Director();
            Purchase supplies = new Purchase(); /*{ quantity = 3, amount = 350.00, taxRate = 7.7 };*/
            Purchase projectOne = new Purchase(); /*{ quantity = 1, amount = 15000.00, taxRate = 0 };*/
            Purchase projectArtemis = new Purchase(); /*{ quantity = 1, amount = 100000.00, taxRate = 2.4 };*/

            supplies = new Purchase(3, 350.00, 77);
            projectOne = new Purchase(1, 15000, 0);
            projectArtemis = new Purchase(1, 100000, 24);

        }
    }
}