using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Logs\log.txt", true))
            {
                file.WriteLine(userNum);
            }
            Console.WriteLine(File.ReadAllText(@"C:\\Logs\log.txt"));
            Console.ReadLine();
        }
    }
}
