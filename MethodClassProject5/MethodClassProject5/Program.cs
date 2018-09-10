using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter an integer that will be divied by 2:");
            int entry = Convert.ToInt32(Console.ReadLine());
            int answer = 0;

            DivisionBy2 adjusted = new DivisionBy2();
            adjusted.Division(entry, out answer);
            Console.WriteLine("Your entered value divided by 2 is: " + answer);

            Console.WriteLine("Please enter another integer that will be divied by 2:");
            decimal entry2 = Convert.ToInt32(Console.ReadLine());
            decimal answer2 = 0;

            DivisionBy2.Division(entry2, out answer2);
            Console.WriteLine(answer2);
            Console.ReadLine();
            
        }
    }
}
