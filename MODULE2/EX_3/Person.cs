using System;
namespace EX_3
{
    public class Person
    {
        //name
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value.Length <= 3)
                {
                    throw new ArgumentException("Name cannot be less than 3 symbols");
                }
                name = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value<=0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                age = value;
            }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person()
        {
        }
    }
}