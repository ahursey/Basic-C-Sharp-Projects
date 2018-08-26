using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a value that will be multiplied by 50:");
            double mult50 = Convert.ToInt32(Console.ReadLine()) * 50;
            Console.WriteLine(mult50);

            Console.WriteLine("Enter a value that will have 25 added to it:");
            double add25 = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine(add25);

            Console.WriteLine("Enter a value that will be divided by 12.5:");
            double divide = Convert.ToInt32(Console.ReadLine()) / 12.5;
            Console.WriteLine(divide);

            Console.WriteLine("Enter a number and console will tell you if it is > 50:");
            bool compare50 = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine(compare50);

            Console.WriteLine("Enter a number and console will provide the remainder when it is divided by 7:");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
