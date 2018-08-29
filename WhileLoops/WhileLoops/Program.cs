using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the answer to life, the universe, and everything?");
            string answer = Console.ReadLine();
            bool guess = answer == "42";

            do
            {
                switch(answer)
                {

                    case "42":
                        Console.WriteLine("Correct.");
                        guess = true;
                        break;

                    default:
                        Console.WriteLine("Incorrect. Try again.");
                        answer = Console.ReadLine();
                        break;

                }
            }

            while (!guess);
            Console.ReadLine();

        }
    }
}
