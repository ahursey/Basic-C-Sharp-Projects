using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    class Program : Employee
    {
        static void Main(string[] args)
        {

            IQuittable quitExecute = new Employee();
            quitExecute.Quit();
            Console.ReadLine();

        }
    }
}
