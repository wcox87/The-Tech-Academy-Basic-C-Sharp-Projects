using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 40, 65, 12, 88, 100 };


            try
            {
                Console.WriteLine("Enter a number to divide by.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                int i = 0;

                while (i <= 4)
                {
                    int solution = numberList[i] / userNumber;
                    Console.WriteLine(numberList[i] + " divided by " + userNumber + " equals " + solution);
                    i++;
                }

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("You have now exited the Try/Catch block and the program is complete");
            Console.ReadLine();
        }
    }
}
