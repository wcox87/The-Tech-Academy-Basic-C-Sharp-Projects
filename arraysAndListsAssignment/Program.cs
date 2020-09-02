using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysAndListsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice1;
            int userChoice2;
            int userChoice3;
            
            string[] strArray = new string[] { "Blue", "Red", "Yellow", "Orange", "Green" };
            
            int[] intArray = new int[] { 1, 5, 22, 40, 99 };

            List<string> strList = new List<string>();
            strList.Add("Rabbit");
            strList.Add("Cat");
            strList.Add("Dog");
            strList.Add("Deer");
            strList.Add("Tiger");

            Console.WriteLine("Please enter a number to choose a color. \n");
            userChoice1 = Convert.ToInt32(Console.ReadLine());
                        
            while (userChoice1 > 4)
            {
                Console.WriteLine("You guessed too high.  Please try again \n");
                Console.WriteLine("Please enter a number to choose a color.");
                userChoice1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You chose " + strArray[userChoice1] + "\n");

            Console.ReadLine();

            Console.WriteLine("Please enter a number to choose a random number. \n");
            userChoice2 = Convert.ToInt32(Console.ReadLine());

            while (userChoice2 > 4)
            {
                Console.WriteLine("You guessed too high.  Please try again \n");
                Console.WriteLine("Please enter a number to choose a random number.");
                userChoice2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You chose " + intArray[userChoice2] + "\n");

            Console.ReadLine();

            Console.WriteLine("Please enter a number to choose an animal. \n");
            userChoice3 = Convert.ToInt32(Console.ReadLine());

            while (userChoice3 > 4)
            {
                Console.WriteLine("You guessed too high.  Please try again \n");
                Console.WriteLine("Please enter a number to choose an animal.");
                userChoice1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You chose a " + strList[userChoice1] + "\n");

            Console.ReadLine();
        }
    }
}  