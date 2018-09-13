
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empOne = new Employee();
            Employee empTwo = new Employee();
            Employee empThree = new Employee();
            Employee empFour = new Employee();
            Employee empFive = new Employee();
            Employee empSix = new Employee();
            Employee empSeven = new Employee();
            Employee empEight = new Employee();
            Employee empNine = new Employee();
            Employee empTen = new Employee();
            empOne.firstName = "Joe";
            empOne.lastName = "Harris";
            empOne.employeeID = 1;
            empTwo.firstName = "Joe";
            empTwo.lastName = "Freeman";
            empTwo.employeeID = 2;
            empThree.firstName = "Aaron";
            empThree.lastName = "Williams";
            empThree.employeeID = 3;
            empFour.firstName = "Sydney";
            empFour.lastName = "Devine";
            empFour.employeeID = 4;
            empFive.firstName = "Sally";
            empFive.lastName = "Williams";
            empFive.employeeID = 5;
            empSix.firstName = "Alex";
            empSix.lastName = "Jones";
            empSix.employeeID = 6;
            empSeven.firstName = "Chris";
            empSeven.lastName = "Christie";
            empSeven.employeeID = 7;
            empEight.firstName = "Nicole";
            empEight.lastName = "Douglass";
            empEight.employeeID = 8;
            empNine.firstName = "Zac";
            empNine.lastName = "Harvey";
            empNine.employeeID = 9;
            empTen.firstName = "Nick";
            empTen.lastName = "Cebron";
            empTen.employeeID = 10;

            List<Employee> employees = new List<Employee>();
            employees.Add(empOne);
            employees.Add(empTwo);
            employees.Add(empThree);
            employees.Add(empFour);
            employees.Add(empFive);
            employees.Add(empSix);
            employees.Add(empSeven);
            employees.Add(empEight);
            employees.Add(empNine);
            employees.Add(empTen);

            List<Employee> namedJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    namedJoe.Add(employee);
                }
            }

            List<Employee> lambdaJoe = employees.Where(x => x.firstName == "Joe").ToList();
            List<Employee> aboveFive = employees.Where(x => x.employeeID > 5).ToList();

            Console.WriteLine(lambdaJoe.Count);
            Console.WriteLine(namedJoe.Count);
            Console.WriteLine(aboveFive.Count);
            Console.ReadLine();

        }
    }
}
