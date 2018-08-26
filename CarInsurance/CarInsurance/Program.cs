using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine()) ;

            Console.WriteLine("Have you ever had a DUI? Please answer \"True\" or \"False\".");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt16(Console.ReadLine());

            bool qualified = age > 15 && DUI == false && tickets < 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);

            Console.ReadLine();

        }
    }
}
