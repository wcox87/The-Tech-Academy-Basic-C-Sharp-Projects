using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to do some math!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Math.numberPlus(userInput);
            Math.numberDivide(userInput);
            Math.numberMultiply(userInput);
            Console.ReadLine();
        }
    }
}
