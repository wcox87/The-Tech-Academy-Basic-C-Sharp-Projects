using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week.");
            string userDay = Console.ReadLine();

            try
            {
                DaysOfTheWeek dayOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay, true);
                Console.WriteLine("Today is " + userDay);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("{0} is not a day of the week.  Please enter an actual day.", userDay);
            }

            Console.ReadLine();
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
