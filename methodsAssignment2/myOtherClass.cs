using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAssignment2
{
    class myOtherClass
    {
        public int myMethod3(int number1, int number2)
        {
            int result = number1 + 92;
            string output = "The result is " + result + " and the second number you passed to this method is " + number2;
            Console.WriteLine(output);
            return result;
        }
    }
}
