using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name1 = "James";
            //string name2 = "Adam";
            //string name3 = "Will";
            //string name4 = "James";

            //if (name4 == "James")
            //{
            //    Console.WriteLine("Your name is James?");
            //    string nameCheck = Console.ReadLine();
            //    bool nameCheck2 = Convert.ToBoolean(nameCheck);

            //    if(nameCheck2 == false)
            //    {
            //        Console.WriteLine("What is your name?");
            //        string userName = Console.ReadLine();
            //        Console.WriteLine("Your name is " + userName);
            //    }

            //    else
            //    {
            //        Console.WriteLine("Good.");
            //    }
            //}

            //else if (name4 == "Adam") 
            //{
            //    Console.WriteLine("Your name is " + name4);
            //}

            //Console.ReadLine();

            int num1 = 17;
            int num2 = 10;
            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
