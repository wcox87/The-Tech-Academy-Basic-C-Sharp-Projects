using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to: The Anonymous Income Comparison Program");
            Console.WriteLine("Your privacy is important to us.  Unless someone pays enough to think otherwise");
            Console.WriteLine("Press enter to continue...");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string personIncomeString1 = Console.ReadLine();
            int personIncome1 = Convert.ToInt32(personIncomeString1);
            Console.WriteLine("Hours worked per week?");
            string personHoursString1 = Console.ReadLine();
            int personHours1 = Convert.ToInt32(personHoursString1);
            int personSalary1 = (personIncome1 * personHours1) * 52;
            
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string personIncomeString2 = Console.ReadLine();
            int personIncome2 = Convert.ToInt32(personIncomeString2);
            Console.WriteLine("Hours worked per week?");
            string personHoursString2 = Console.ReadLine();
            int personHours2 = Convert.ToInt32(personHoursString2);
            int personSalary2 = (personIncome2 * personHours2) * 52;
            Console.WriteLine("Annual Salary Person 1:");
            Console.WriteLine(personSalary1);
            Console.WriteLine("Annual Salary Person 2:");
            Console.WriteLine(personSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryCompare = personSalary1 > personSalary2;
            Console.WriteLine(salaryCompare);
            Console.ReadLine();
        }
    }
}
