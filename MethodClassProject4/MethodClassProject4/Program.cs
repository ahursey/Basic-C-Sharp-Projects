using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject4
{
    class Program
    {
        static void Main(string[] args)
        {

            optionalClass result = new optionalClass();

            Console.WriteLine("Please enter an integer:");
            int firstEntry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please optionally enter a second integer:");
            string input = Console.ReadLine();
            int secondEntry = 0;
            if (!string.IsNullOrEmpty(input))
            {
                secondEntry = Convert.ToInt16(input);
                result.optionalModifier(firstEntry, secondEntry);
                Console.WriteLine("The first modified entry is: " + result.x + " and the second modified entry is: " + result.y);

            }
            else
            {
                result.optionalModifier(firstEntry);
                Console.WriteLine("The first modified entry is: " + result.x);

            }

            Console.ReadLine();

        }
    }
}
