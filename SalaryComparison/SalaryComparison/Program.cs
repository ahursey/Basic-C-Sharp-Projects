using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            byte rate1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            byte weekHours1 = Convert.ToByte(Console.ReadLine());
            int annual1 = rate1 * weekHours1 * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            byte rate2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            byte weekHours2 = Convert.ToByte(Console.ReadLine());
            int annual2 = rate2 * weekHours2 * 52;

            Console.WriteLine("Annual salary of person 1:");
            Console.WriteLine(annual1);

            Console.WriteLine("Annual salary of person 2:");
            Console.WriteLine(annual2);

            bool compare = annual1 > annual2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compare);

            Console.ReadLine();

        }
    }
}
