using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a value to be operated on.");
            int entry = Convert.ToInt32(Console.ReadLine());

            integerClass result = new integerClass();
            result.integerMod(entry);
            Console.WriteLine("The result is: " + result.x);
            Console.ReadLine();

            decimal entry2 = Convert.ToDecimal(entry);
            result.integerMod(entry2);
            Console.WriteLine("The result is: " + result.y);
            Console.ReadLine();

            string entry3 = Convert.ToString(entry);
            result.integerMod(entry3);
            Console.WriteLine("The result is: " + result.w);
            Console.ReadLine();
            
        }
    }
}
