using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The current time and date is: " + DateTime.Now.ToString());

            Console.WriteLine("Please enter an integer value: ");
            int integerX = Convert.ToInt16(Console.ReadLine());

            DateTime addedTime = DateTime.Now;
            addedTime = addedTime.AddHours(integerX);
            Console.WriteLine("In " + integerX + " hours, it will be: " + addedTime);
            Console.ReadLine();

        }
    }
}
