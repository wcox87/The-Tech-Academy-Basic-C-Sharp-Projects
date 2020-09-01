using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insuranceQaulification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);
            
            Console.WriteLine("Have you ever had a DUI (Enter true or false)");
            string dui = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(dui);
            

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketsInt = Convert.ToInt32(tickets);

            bool qualified1 = duiBool;
            bool qualified2 = ticketsInt < 3;

            bool qualifiedFinal = (ageInt > 15 ^ qualified1 && qualified2);
            Console.WriteLine("Are you eligible? " + qualifiedFinal);
            Console.ReadLine();
           

        }
    }
}
