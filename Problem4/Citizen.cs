using System;
namespace robotApocalypse
{
    public class Citizen
    {
        //field for the name of the citizen
        public string Name { get; set; }
        //field for the age
        public int Age { get; set; }
        //field for the id
        public string Id { get; set; }

        //the empty constructor
        public Citizen(){ }
        //the constructor with parameters
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

    }
}
