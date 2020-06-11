using ConsoleMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            var instruction = new Instructions();
            string code = Console.ReadLine();
            while (code != "END")
            {
                Console.WriteLine(instruction.Execute(code));
                code = Console.ReadLine();
            }
        }
    }
}
