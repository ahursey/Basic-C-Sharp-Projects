using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:");
            var entry = Console.ReadLine();

            Start:
            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), entry);
      
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                entry = Console.ReadLine();
                goto Start;
            }

            DaysOfTheWeek value = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), entry);

            Console.WriteLine(value);
            Console.ReadLine();
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
    }
}
