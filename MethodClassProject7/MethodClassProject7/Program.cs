using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee();
            firstEmployee.firstName = "Sample";
            firstEmployee.lastName = "Student";
            firstEmployee.SayName();
            Console.ReadLine();
        }
    }
}
