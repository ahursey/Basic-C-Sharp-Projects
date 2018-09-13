using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> empList = new Employee<string>();
            Employee<int> empInt = new Employee<int>();
            empList.things = new List<string>();
            empList.things.Add("Albert");
            empList.things.Add("Montgomery");
            empInt.things = new List<int>();
            empInt.things.Add(20);
            empInt.things.Add(30);

            foreach (string item in empList.things)
            {
                Console.WriteLine(item);
            }

            foreach (int item in empInt.things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
