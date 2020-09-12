using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceAssignment
{
    public class Employee : Person
    {
        public Employee()
        {
            Id = 001;
        }
        public int Id { get; set; }
    }


}
