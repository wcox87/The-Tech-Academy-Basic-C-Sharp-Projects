using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceAssigment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            List<string> myThings = new List<string>() { "Spectacles", "Wallet", "Watch" };
            employee.Things.Concat(myThings);
            //employee.Things = myThings;
            //employee.Things.Add("Spectacles");
            //employee.Things.Add("Wallet");
            //employee.Things.Add("Watch");
            //employee.printThings();

        }
    }
}
