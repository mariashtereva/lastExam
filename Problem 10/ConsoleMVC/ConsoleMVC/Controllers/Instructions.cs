using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Controllers
{
    public class Instructions
    {
        public long Execute(string command)
        {
            string[] codeArgs = command.Split(' ');
            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        break;
                    }
                case "DEC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        break;
                }
                case "ADD":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = int.Parse(codeArgs[1]);
                        long operandTwo = int.Parse(codeArgs[2]);
                        result = (long)(operandOne * operandTwo);
                        break;

                    }
            }
            return result;
        }
    }
}
