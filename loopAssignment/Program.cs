using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace loopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color...");
            string color = Console.ReadLine();
            string color2 = color.ToUpper();
            bool colorGuess = color2 == "GREEN";

            while (!colorGuess)
            {

            switch (color2) 
                {

                    case "RED":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess my favorite color...");
                        color = Console.ReadLine();
                        color2 = color.ToUpper();
                        break;

                    case "BLUE":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess my favorite color...");
                        color = Console.ReadLine();
                        color2 = color.ToUpper();
                        break;

                    case "YELLOW":
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess my favorite color...");
                        color = Console.ReadLine();
                        color2 = color.ToUpper();
                        break;

                    case "GREEN":
                        Console.WriteLine("You guessed green. You are correct.");
                        colorGuess = true;
                        break;

                    default:
                    Console.WriteLine("You are incorrect.  Try again.");
                    Console.WriteLine("Guess my favorite color...");
                    color = Console.ReadLine();
                    color2 = color.ToUpper();
                    break;
                }
            }

            Console.ReadLine();
            Console.WriteLine("Good job.  Now guess the number I'm thinking of.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberGuess = number == 42;

            do
            {
                switch (number)
                {
                    case 47:
                        Console.WriteLine("You are close, but not quite there. Think smaller and try again.");
                        Console.WriteLine("Guess a number...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 86:
                        Console.WriteLine("You are close, but not quite there. Think much smaller and try again.");
                        Console.WriteLine("Guess a number...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 27:
                        Console.WriteLine("You are close, but not quite there. Think larger and try again.");
                        Console.WriteLine("Guess a number...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 9:
                        Console.WriteLine("You are close, but not quite there. Think much larger and try again.");
                        Console.WriteLine("Guess a number...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 42:
                        Console.WriteLine("You guessed 42.  Good job, unless you looked at the source code, then shame on you!");
                        numberGuess = true;
                        break;

                    default:
                        Console.WriteLine("You are close, but not quite there. Try again.");
                        Console.WriteLine("Guess a number...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!numberGuess);
            Console.ReadLine();

        }
    }
}
