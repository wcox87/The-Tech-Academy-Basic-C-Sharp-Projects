using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 2;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("10 minus 5 = " + difference.ToString());
            //Console.ReadLine;

            //int product = 10 * 5;
            //int quotient = 100 / 5;
            //Console.WriteLine(product);
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 72;

            //bool isWarm = currentTemperature > roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("1) Please enter a number to have it multiplied by 50.");
            string stringInput1 = Console.ReadLine();
            int userInput1 = Convert.ToInt32(stringInput1);
            int userOutput1 = userInput1 * 50;
            Console.WriteLine(userInput1 + " * 50 = " + userOutput1);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            Console.WriteLine("2) Please enter a number to add 25 to it.");
            string stringInput2 = Console.ReadLine();
            int userInput2 = Convert.ToInt32(stringInput2);
            int userOutput2 = userInput2 + 25;
            Console.WriteLine(userInput2 + " + 25 = " + userOutput2);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            Console.WriteLine("3) Please enter a number to divide it by 12.5.");
            string stringInput3 = Console.ReadLine();
            double userInput3 = Convert.ToDouble(stringInput3);
            double userOutput3 = userInput3 / 12.5;
            Console.WriteLine(userInput3 + " / 12.5 = " + userOutput3);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            Console.WriteLine("4) Please enter a number to check if it's greater than 50.");
            string stringInput4 = Console.ReadLine();
            int userInput4 = Convert.ToInt32(stringInput4);
            bool userOutput4 = userInput4 > 50;
            Console.WriteLine(userInput4 + " > 50: " + userOutput4);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            Console.WriteLine("5) Please enter a number to see the remainder after dividing by 7.");
            string stringInput5 = Console.ReadLine();
            int userInput5 = Convert.ToInt32(stringInput5);
            int userOutput5 = userInput5 % 7;
            Console.WriteLine(userInput5 + " % 7 = " + userOutput5);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
