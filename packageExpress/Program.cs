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

            if (packageWeight > 50)
            {
                Console.WriteLine("Package to big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package width (in inches): ");
            string packageWidthString = Console.ReadLine();
            int packageWidth = Convert.ToInt32(packageWidthString);

            Console.WriteLine("Please enter the package height (in inches): ");
            string packageHeightString = Console.ReadLine();
            int packageHeight = Convert.ToInt32(packageHeightString);

            Console.WriteLine("Please enter the package length (in inches): ");
            string packageLengthString = Console.ReadLine();
            int packageLength = Convert.ToInt32(packageLengthString);

            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package to big to be shipped via Package Express. Have a good day.");
            }

            float shipping = (packageHeight * packageLength * packageWidth) * packageWeight / 100;

            string result = ("Your estimated total for shipping this package is: $" + shipping);
            Console.WriteLine(result);
            Console.WriteLine("Thank you!");
            
            Console.ReadLine();
        }
    }
}
