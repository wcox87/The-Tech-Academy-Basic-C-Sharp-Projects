using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssignment224
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number and press enter.\n Then another number and press enter.,\n They will be added together then divided by two: ");
            Operations.Operation(Convert.ToDouble(Console.ReadLine()));
            Console.ReadLine();
            Console.WriteLine("Please enter a number and press enter.\n Then another number and press enter.,\n They will be multiplied together\n ");
            Operations.Multiply(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
            int age1;
            string firstName1;
            string lastName1;
            Operations.newMethod(out age1, out firstName1, out lastName1);
            Console.WriteLine(age1);
            Console.WriteLine(firstName1);
            Console.WriteLine(lastName1);
            Console.WriteLine("Type a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type another number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int sum1;
            sum1 = Operations.Overload(x, y);
            Console.WriteLine("Your numbers divided: " + sum1);
            Console.WriteLine("Type a number please: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type another number: ");
            double b = Convert.ToInt32(Console.ReadLine());
            double sum2;
            sum2 = Operations.Overload(a, b);
            Console.WriteLine("Your numbers multiplied: " + sum2 + "\n");
            Console.WriteLine("End of program.\n\nThanks for playing! ");
            Console.ReadLine();
        }
    }
}
