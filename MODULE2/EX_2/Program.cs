using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //to do
            //what is a factorial
            //4! = 4*3*2*1 = 24
            int number = int.Parse(Console.ReadLine());
            int fact = Factorial(number);
            Console.WriteLine(fact);
        }

        private static int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }

    }
}
