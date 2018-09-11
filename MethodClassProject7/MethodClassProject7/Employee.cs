using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject7
{
    public class Employee : Person
    {
        public new void SayName()
        {
            base.SayName();
        }
    }
}
