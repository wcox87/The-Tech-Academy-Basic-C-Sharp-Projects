using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment248
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            Employee<int> employee2 = new Employee<int>();
            employee.things = new List<string>() { "Will", "Adam", "James" };
            employee2.things = new List<int>() { 100, 88, 9977 };

            foreach (var thing in employee.things)
            {
                Console.WriteLine(thing);
            }
            foreach (var thing1 in employee2.things)
            {
                Console.WriteLine(thing1);
            }

            Console.ReadKey();
        }
    }
}
