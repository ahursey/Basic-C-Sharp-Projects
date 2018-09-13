using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Number value = new Number();
            Console.WriteLine("Please enter a number value:");
            value.Amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(value.Amount);
            Console.ReadLine();

        }
    }
}
