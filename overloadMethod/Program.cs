using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = "Will";
            employee.lastName = "Cox";
            employee.ID = 8675309;

            Employee employee1 = new Employee();
            employee1.firstName = "Seamus";
            employee1.lastName = "Blackley";
            employee1.ID = 9035768;

            Console.WriteLine("Checking to see if ID's match...");
            Console.WriteLine(employee.Equals(employee1));
            Console.ReadLine();
        }
    }
}
