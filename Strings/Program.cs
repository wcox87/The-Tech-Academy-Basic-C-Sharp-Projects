using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Will";
            //string quote = "The man said, \"Hello\", Jesse. \n Hello ona  new line. \n \t Hello on a tab.";
            //string filename = @"C:\Users\Will";

            //bool trueorfalse = name.Contains("l");
            //trueorfalse = name.EndsWith("l");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(quote);
            //Console.Read();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Will");

            Console.WriteLine(sb);
            Console.Read();

            sb.Append("My name is Will");

            Console.WriteLine(sb);
            Console.Read();

            sb.Append("My name is Will");

            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
