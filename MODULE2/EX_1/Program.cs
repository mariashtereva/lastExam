using System;
//using Linq
using System.Linq;

namespace EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array nums (code is given in the exercise)
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            //making a variable for the last ODD element using LINQ.Last()
            int result = nums.LastOrDefault(element => element % 2 != 0);
            //print
            Console.WriteLine(result);
        }
    }
}
