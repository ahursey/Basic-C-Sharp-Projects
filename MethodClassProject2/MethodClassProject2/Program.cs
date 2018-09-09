using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter an integer value:");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second integer value:");
            int two = Convert.ToInt32(Console.ReadLine());


            integerClass result = new integerClass();
            result.integerModifier(one, two);
            result.integerModifier(5, 2);

        }
    }
}
