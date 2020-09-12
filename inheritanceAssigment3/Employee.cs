using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceAssigment3
{
    public class Employee : Person, IQuittable
    {
        public override void sayName()
        {
            Console.WriteLine("This is an example override of a virtual method. ");
            base.sayName();
        }

        public void Quit()
        {
            Console.WriteLine("An employee has left the building.");
            Console.ReadLine();
        }
        public int Id { get; set; }
    }


}
