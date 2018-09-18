using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your age in years.");
            retry:
            int age = 0;
            try
            {
                age = Convert.ToInt16(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("A negative number or zero was entered. Please enter only positive integer values.");
                    goto retry;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The wrong datatype was entered. Please only enter positive integer values.");
                goto retry;
            }
            
            DateTime timeNow = DateTime.Now;
            int yearBorn = timeNow.Year - age;
            Console.WriteLine("You were born in the year " + yearBorn);
            Console.ReadLine();
            
        }
    }
}
