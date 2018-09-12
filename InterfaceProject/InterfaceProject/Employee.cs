using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    class Employee : IQuittable
    {
        void IQuittable.Quit()
        {
            Console.WriteLine("You have quit the game.");
        }
    }
}
