using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight (in Lbs): ");
            string packageWeightString = Console.ReadLine();
            int packageWeight = Convert.ToInt32(packageWeightString);

            Console.WriteLine("Please enter the package width (in inches): ");
            string packageWidthString = Console.ReadLine();
            int packageWidth = Convert.ToInt32(packageWidthString);
            
            Console.WriteLine("Please enter the package height (in inches): ");
            string packageHeightString = Console.ReadLine();
            int packageHeight = Convert.ToInt32(packageHeightString);

            Console.WriteLine("Please enter the package length (in inches): ");
            string packageLengthString = Console.ReadLine();
            int packageLength = Convert.ToInt32(packageLengthString);

            float shipping = (packageHeight * packageLength * packageWidth) * packageWeight / 100;

            string result = packageWeight > 50 ? "Package to big to be shipped via Package Express." : ("Your estimated total for shipping this package is: $" + shipping);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
