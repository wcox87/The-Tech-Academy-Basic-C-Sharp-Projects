using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceAssignment
{
    public class Person

    {
        public Person()
        {
            firstName = "First";
            lastName = "Last";
        }

        public void sayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
    }


}
