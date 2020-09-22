using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment265
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(100, "Will", "Cox");
            Employee emp2 = new Employee(101, "Adam", "Brown");
            Employee emp3 = new Employee(102, "Staci", "Baatz");
            Employee emp4 = new Employee(103, "Joe", "Schmoe");
            Employee emp5 = new Employee(104, "James", "B");
            Employee emp6 = new Employee(105, "Simon", "Says");
            Employee emp7 = new Employee(106, "Joe", "Smith");
            Employee emp8 = new Employee(107, "Paul", "White");
            Employee emp9 = new Employee(108, "Ryan", "Peters");
            Employee emp10 = new Employee(109, "Sarah", "Connor");
            List<Employee> employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10 };
            List<Employee> joes = new List<Employee>() { };
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            List<Employee> newList = employees.Where(x => x.firstName == "Joe").ToList();
            List<Employee> newList2 = employees.Where(x => x.empID > 5).ToList();

        }
        struct Employee
        {
            public int empID;
            public string firstName;
            public string lastName;
            public Employee(int empId, string FirstName, string LastName)
            {
                empID = empId;
                firstName = FirstName;
                lastName = LastName;
            }
        }
    }
}
