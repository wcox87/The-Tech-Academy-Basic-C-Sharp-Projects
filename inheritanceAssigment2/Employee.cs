using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceAssignment
{
    public class Employee : Person
    {
        public override void sayName()
        {
            Console.WriteLine("This is an example override of a virtual method. ");
            base.sayName();
        }
        public int Id { get; set; }
    }


}
