using System;
namespace employee
{
    public class Employee
    {
        //field for the first name
        public string FirstName { get; set; }
        //field for the last name
        public string LastName { get; set; }
        //field for the age
        public int Age { get; set; }
        //field for the initial salary
        public double Salary { get; set; }

        //method for the increase of the salary based on the age of the employee
        public void IncreaseSalary(double bonus)
        {
            //if the employee is less than 30
            if(this.Age <= 30)
            {
                //increase of the salary is half the bonus percentage
                this.Salary += this.Salary * bonus / 200;
            }
            //if the employee is more than 30
            else
            {
                //increase of the salary is the full bonus percentage
                this.Salary += this.Salary * bonus / 100;
            }
        }

        //the empty constructor
        public Employee(){ }
        //the cvontructor with parameters
        public Employee(string first_name, string last_name, int age, double salary)
        {
           FirstName = first_name;
           LastName = last_name;
           Age = age;
           Salary = salary;
        }

        



    }
}
