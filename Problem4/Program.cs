using System;
using System.Collections.Generic;
using System.Linq;

namespace robotApocalypse
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creates an empty list of robots
            List<Robot> robots = new List<Robot>();
            //creates an empty list of citizens
            List<Citizen> citizens = new List<Citizen>();

            //the commands input
            var line = Console.ReadLine().Split().ToArray();

            while (line[0] != "End")
            {
                //if there are two parts of the array, it is a robot
                if (line.Count() == 2)
                {
                    robots.Add
                       (
                       new Robot()
                       {
                            Model = line[0],
                            Id = line[1]
                       }
                       );
                }
                //if there are three parts, it is a citizen
                else if(line.Count() == 3)
                {
                    citizens.Add
                       (
                       new Citizen()
                       {
                           Name = line[0],
                           Age = int.Parse(line[1]),
                           Id = line[2]
                       }
                       );
                }

                //next command
                line = Console.ReadLine().Split().ToArray();
            }

            //the searched last three digits of the id
            string searching = Console.ReadLine();

            //print ids of criminal citizens
            foreach (var citizen in citizens)
            {
                //checks if the last three digits of the id are the searched ones
                var result = citizen.Id.Substring(citizen.Id.Length - 3);
                if (result == searching)
                {
                    Console.WriteLine(citizen.Id);
                }


            }
            //print ids of criminal robots
            foreach (var robot in robots)
            {
                //checks if the last three digits of the id are the searched ones
                var result = robot.Id.Substring(robot.Id.Length - 3);
                if (result == searching)
                {
                    Console.WriteLine(robot.Id);
                }
                
            }

        }
    }
}
