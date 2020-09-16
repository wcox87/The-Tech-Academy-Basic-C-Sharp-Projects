using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine("Please enter the number of hours to add.");
            int userHours = Convert.ToInt32(Console.ReadLine());
            DateTime result = date.AddHours(userHours);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }
    }
}
