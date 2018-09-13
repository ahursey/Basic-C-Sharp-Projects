using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employeeOne = new Employee();
            employeeOne.employeeID = 1;
            employeeOne.firstName = "Aaron";
            employeeOne.lastName = "Adamson";

            Employee employeeTwo = new Employee();
            employeeTwo.employeeID = 2;
            employeeTwo.firstName = "Bob";
            employeeTwo.lastName = "Bojangles";

            Employee employeeThree = new Employee();
            employeeThree.employeeID = 3;
            employeeThree.firstName = "Chris";
            employeeThree.lastName = "Christie";

            List<Employee> employees = new List<Employee> { };
            employees.Add(employeeOne);
            employees.Add(employeeTwo);
            employees.Add(employeeThree);

            Console.WriteLine("Please enter the name of an employee:");
            string firstNameEntry = Console.ReadLine();

            int eIDOne = 0;

            foreach (Employee employee in employees)
            {
                if (firstNameEntry == employee.firstName)
                    eIDOne = employee.employeeID;
            }

            Console.WriteLine("Thank you. Now please enter the last name of that employee to see if they exist:");
            string lastNameEntry = Console.ReadLine();

            int eIDTwo = 0;

            foreach (Employee employee in employees)
            {
                if (lastNameEntry == employee.lastName)
                    eIDTwo = employee.employeeID;
            }

            Console.WriteLine(eIDOne == eIDTwo);
            Console.ReadLine();
           


    }
    }
}
