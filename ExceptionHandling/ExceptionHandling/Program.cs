using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            RetryPoint:
            try
            {
                List<int> intList = new List<int>();
                intList.Add(3);
                intList.Add(6);
                intList.Add(9);
                intList.Add(12);
                intList.Add(15);
                Console.WriteLine("Please enter a number to divide the list of integers by.");
                int divisor = Convert.ToInt16(Console.ReadLine());
                foreach(int i in intList)
                {
                    Console.WriteLine(i / divisor);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect data type. Please enter an integer.");
                goto RetryPoint;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
                goto RetryPoint;
            }
            Console.WriteLine("Thank you, your input was a non-zero integer and the program has finished.");
            Console.ReadLine();
        }
    }
}
