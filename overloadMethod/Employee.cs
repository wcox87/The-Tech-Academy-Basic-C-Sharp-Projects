using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadMethod
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee1)
        {
            return employee.ID == employee1.ID;
        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            return employee.ID != employee1.ID;
        }
        public override bool Equals(Object Obj)
        {
            if (Obj is null) return false;
            if (ReferenceEquals(this, Obj)) return true;
            if (Obj.GetType() != this.GetType()) return false;
            return this.ID.Equals(((Employee)Obj).ID);
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
