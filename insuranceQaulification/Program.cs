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
                        
            //qualified if Age is over 15 and no DUI and 3 or fewer tickets          
            bool qualifiedFinal = (ageInt > 15) && !duiBool && (ticketsInt <=3);
            
            Console.WriteLine("Are you eligible? " + qualifiedFinal);
            Console.ReadLine();
           

        }
    }
}
