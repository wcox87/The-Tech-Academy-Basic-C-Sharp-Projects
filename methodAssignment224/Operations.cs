using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssignment224
{
    public static class Operations
    {
        public static void Operation(double x, double y = default)
        {

            bool entered = double.TryParse(Console.ReadLine(), out y);
            double num1 = x;
            double num2 = y;
            double sum = (num1 + num2) / 2;
            Console.WriteLine(sum);

        }
        public static void Multiply(int x, int y = default)
        {
            bool entered = int.TryParse(Console.ReadLine(), out y);
            int num1 = x;
            int num2 = y;
            int product = (num1 * num2) * 1;
            Console.WriteLine(product);
        }

        public static void newMethod(out int age, out string firstName, out string lastName)
        {
            Console.WriteLine("Please type your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("And your last name please: ");
            lastName = Console.ReadLine();
        }
        public static int Overload(int x, int y)
        {

            return x / y;
        }
        public static double Overload(double x, double y)
        {

            return x * y;
        }
    }
}
