using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color... (only use lowercase colors)");
            string color = Console.ReadLine();
            string color2 = color.ToUpper();

            Console.WriteLine(color2);
            Console.ReadLine();

            bool colorGuess = color == "green";
        }
    }
}
