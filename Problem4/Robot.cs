using System;
namespace robotApocalypse
{
    public class Robot
    {
        //field for the model/ name of the robot
        public string Model { get; set; }
        //field for the id of the robot
        public string Id { get; set; }

        //the empty constructor
        public Robot() { }
        //the constructor with parameters
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

    }
}
