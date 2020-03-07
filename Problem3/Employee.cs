using System;
namespace employee
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double bonus)
        {
            if(this.Age <= 30)
            {
                this.Salary += this.Salary * bonus / 200;
            }
            else
            {
                this.Salary += this.Salary * bonus / 100;
            }
        }

        public Employee(){ }
        public Employee(string first_name, string last_name, int age, double salary)
        {
           FirstName = first_name;
           LastName = last_name;
           Age = age;
           Salary = salary;
        }

        



    }
}
