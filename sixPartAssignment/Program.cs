using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART ONE

            string[] birds = { "Robin", "Eagle", "Canary", " " };
            Console.WriteLine("What is your favorite bird?");
            string userInput = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                if (birds[i] == " ")
                {
                    birds[i] = userInput;
                }

                else
                {
                    Console.WriteLine("This slot is already taken by " + birds[i] + " We're working to add you bird to the list.\n");
                }
            }

            Console.WriteLine("Your bird has been added. Press Enter to see the full list.. \n");
            Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(birds[i] + "\n");
            }

            Console.ReadLine();

            //PART TWO

            //for (int j = 1; j > 0; j++)
            //{
            //    Console.WriteLine("I'm broken!");
            //}

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("I'm a functioning loop!");
            }

            Console.ReadLine();

            //PART THREE

            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("This is good use of the < operator");
            }

            Console.ReadLine();

            for (int l = 0; l <= 8; l++)
            {
                Console.WriteLine("This is a good use of the <= operator");
            }

            Console.ReadLine();

            //PART FOUR AND FIVE

            List<string> names = new List<string>() { "Will", "Adam", "Sarah", "James", "Will" };
            Console.WriteLine("Please enter the name of the person you are searching for.");
            string userInput2 = Console.ReadLine();

            //for (int m = 0; m < names.Capacity; m++)
            //{
            //    if (names[m] == userInput2)
            //    {
            //        Console.WriteLine("We found " + userInput2 + " in our database");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("We're sorry. " + userInput2 + " is not in our database.");
            //    }
            //}

            if (names.Contains(userInput2, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("We found " + userInput2 + " in our database.");
                Console.WriteLine("The indices of this item is: " + names.IndexOf(userInput2));
            }
            else
            {
                Console.WriteLine("We're sorry " + userInput2 + " is not in our database");
            }

            Console.ReadLine();

            //PART SIX

            List<string> names2 = new List<string>() { "Will", "Adam", "Sarah", "James", "Will" };
            var dict = new Dictionary<string, int>();

            foreach (var count in names2)
            {
                if (dict.ContainsKey(count))
                {
                    dict[count]++;
                }
                else
                {
                    dict[count] = 1;
                }
            }

            foreach(var val in dict)
            {
                Console.WriteLine("{0} occured {1} times", val.Key, val.Value);
            }
            Console.ReadLine();

        }
    }
}
