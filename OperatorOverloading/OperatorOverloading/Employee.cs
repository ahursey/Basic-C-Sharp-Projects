using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int employeeID { get; set; }

        public static bool operator ==(Employee one, Employee two)
        {
            if (one.employeeID == two.employeeID)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee one, Employee two)
        {
            if (one.employeeID != two.employeeID)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            Employee e = obj as Employee;
            if (e != null)
            {
                return e == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return employeeID.GetHashCode();
        }

    }
}
