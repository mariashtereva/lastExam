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

            List<Employee> employees = new List<Employee>();

            int lines = int.Parse(Console.ReadLine());
            
            while(lines > 0)
            {

                var cmdArgs = Console.ReadLine().Split().ToArray();
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

            double bonus = double.Parse(Console.ReadLine());
         

            // Print
            foreach (var employee in employees)
            {
                employee.IncreaseSalary(bonus);
                Console.WriteLine($"{employee.FirstName} {employee.LastName} get {employee.Salary:0.00} leva");
            }


        }
    }
}
