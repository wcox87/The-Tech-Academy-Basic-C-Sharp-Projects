using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_307
{
    class Program
    {
        public class InputException : Exception
        {
            public InputException()
                : base() { }
            public InputException(string message) 
                : base(message) { }
        }
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());
                if (age < 1)
                {
                    throw new InputException();
                }
                var today = DateTime.Now;

                string Date = DateTime.Now.ToShortDateString();

                var year1 = today.Year - age;      

                Console.WriteLine("You were born in " + year1);
            }

            catch (FormatException)        
            {
                Console.WriteLine("Please enter a whole number greater than 0.");
            }
            catch (InputException)         
            {
                Console.WriteLine("You have entered 0 or a negative number.  Either you're way too young or you accidentally typed the wrong thing.");
            }
            catch (Exception)              
            {
                Console.WriteLine("We ran into an error and we're not sure what it is.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
