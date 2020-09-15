using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 92;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }

        struct Number
        {
            public int Amount;
        }
    }
}
