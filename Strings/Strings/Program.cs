using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first name.");
            string first = Console.ReadLine();
            first = first.ToUpper();
            Console.WriteLine("Enter your last name.");
            string last = Console.ReadLine();
            last = last.ToUpper();

            StringBuilder welcome = new StringBuilder();
            welcome.Append("Welcome to the world of Mars. ");
            welcome.Append("There is a rover out back of the spaceship that you are free to use. ");
            welcome.Append("Please see that it remains unharmed during your investigation of the Olympus Mons.");
            welcome.Append("\nGood luck!");

            Console.WriteLine("Thank you, " + first + " " + last + "\n" + welcome);
            Console.ReadLine();

        }
    }
}
