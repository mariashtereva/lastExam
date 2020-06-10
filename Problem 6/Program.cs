using System;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //input length of an array
            int length = int.Parse(Console.ReadLine());
            
            //length should be an even number
            if (length % 2 == 0)
            {
                //make an array
                string line = Console.ReadLine();
                //input from one line
                string[] readLine = line.Split(' ');
                //make the array of integers
                int[] arr = Array.ConvertAll(readLine, int.Parse);

                //check of the length of the array is the input number
                if(arr.Length != length)
                {
                    throw new ArgumentException("Wrong number of integers in the array");
                }

                //split the array into two parts
                var firstArray = arr.Take(arr.Length / 2).ToArray();
                var secondArray = arr.Skip(arr.Length / 2).ToArray();
                //sort the first half in ascending order
                Array.Sort(firstArray);
                //sort the secon half in descending order
                Array.Sort(secondArray);
                Array.Reverse(secondArray);

                //print the two array on one line
                Console.WriteLine(string.Join(" ", firstArray) + " " + string.Join(" ", secondArray));
            }

            //if length is an odd number throw an exception
            else
            {
                throw new ArgumentException("Number not even");
            }


        }

       
    }

}
