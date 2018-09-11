using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject6
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee numberOne = new Employee();
            numberOne.FirstName = "Sample";
            numberOne.LastName = "Student";
            numberOne.SayName();
            Console.ReadLine();

        }
    }
}
