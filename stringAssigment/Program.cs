using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            sb.Append(name + " enjoyed spending time outdoors and taking long walks. ");

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            sb.Append("They also had a book that was " + color + " and they very much enjoyed spending their time reading it over and over again. ");
            
            Console.WriteLine("What is the name of the city you live in?");
            string city = Console.ReadLine();
            city = city.ToUpper();
            sb.Append("But, as the sun began to set " + name + " knew it was time to return to " + city + " which was their home. ");

            
            Console.WriteLine(name + "'s favorite color is " + color + ". And they live in " + city + ".");
            Console.ReadLine();
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
