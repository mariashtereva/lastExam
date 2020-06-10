using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            //how many lines
            int lines = int.Parse(Console.ReadLine());

            while (lines > 0)
            {
                //commands input
                var cmdArgs = Console.ReadLine().Split().ToArray();
                //adds employees to the list
                people.Add
                    (
                    new Person()
                    {
                        Name = cmdArgs[0],
                        Age = int.Parse(cmdArgs[1])
                    }
                    );
                lines--;
            }


            foreach (var person in people)
            {
              
                //output
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }



        }
    }
}
