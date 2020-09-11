using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass mc = new myClass();
            Console.WriteLine("Please enter a number...");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int userResult = mc.myMethod(userNum);
            Console.WriteLine("The result is {0}", userResult);
            Console.ReadLine();

            Console.WriteLine("Please enter a number with a decimal...");
            float userNum1 = float.Parse(Console.ReadLine());
            float userResult1 = mc.myMethod(userNum1);
            Console.WriteLine("The result is {0}", userResult1);
            Console.ReadLine();

            Console.WriteLine("Please enter another number...");
            string userInput = (Console.ReadLine());
            string userResult2 = mc.myMethod(userInput);
            Console.WriteLine("The result is " + userResult2);
            Console.ReadLine();
        }
    }
}
