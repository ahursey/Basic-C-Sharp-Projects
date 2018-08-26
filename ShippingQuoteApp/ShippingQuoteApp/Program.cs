using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight.");
            decimal pkgWeight = Convert.ToDecimal(Console.ReadLine());

            if (pkgWeight > 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please enter the package width:");
                decimal pkgWidth = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                decimal pkgHeight = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                decimal pkgLength = Convert.ToDecimal(Console.ReadLine());

                decimal pkgDimensions = pkgWidth + pkgHeight + pkgLength;

                if (pkgDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }

                else
                {
                    decimal total = (pkgDimensions * pkgWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping is: $" + total);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }

            }
        }
    }
}
