using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAssignment
{
    class Math
    {
        public static void numberPlus(int userNum)
        {
            int userTotal = userNum + 10;
            Console.WriteLine(userNum + " plus 10 equals " + userTotal);
        }

        public static void numberMultiply(int userNum)
        {
            int userTotal = userNum * 5;
            Console.WriteLine(userNum + " times 5 equals " + userTotal);
        }

        public static void numberDivide(int userNum)
        {
            int userTotal = userNum / 2;
            Console.WriteLine(userNum + " divided by 2 equals " + userTotal);
        }
    }
}
