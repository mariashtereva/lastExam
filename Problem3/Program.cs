using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an empty list for the employees
            List<Employee> employees = new List<Employee>();

            //how many lines
            int lines = int.Parse(Console.ReadLine());

            while(lines > 0)
            {
                //commands input
                var cmdArgs = Console.ReadLine().Split().ToArray();
                //adds employees to the list
                employees.Add
                    (
                    new Employee()
                    {
                        FirstName = cmdArgs[0],
                        LastName = cmdArgs[1],
                        Age = int.Parse(cmdArgs[2]),
                        Salary = double.Parse(cmdArgs[3])
                    }
                    );
                lines--;
            }

            //bonus percentage input
            double bonus = double.Parse(Console.ReadLine());
         
            //for every employee
            foreach (var employee in employees)
            {
                //increasing the salary using the method from class Employee
                employee.IncreaseSalary(bonus);
                //output
                Console.WriteLine($"{employee.FirstName} {employee.LastName} get {employee.Salary:0.00} leva");
            }


        }
    }
}
