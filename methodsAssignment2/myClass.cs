using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAssignment2
{
    public class myClass
    {
        //public int myMethod(int num1)
        //{
        //    int result = num1 + 50;
        //    return result;
        //}
        public int myMethod(int num1)
        {
            int result = num1 + 50;
            //Console.WriteLine("Result");
            return result;
        }

        public float myMethod(float num1)
        {
            float result = num1 * 4;
            //Console.WriteLine("Result");
            return result;
        }

        public string myMethod(string num1)
        {
            int num2 = Convert.ToInt32(num1);
            int result = num2 - 40;
            string final = result.ToString();
            //Console.WriteLine("Result");
            return final;
        }

        public int myMethod2(int num1 = 10, int num2 = 100)     
        {
            int result = num1 + num2;
            return result;
        }
    }
}
