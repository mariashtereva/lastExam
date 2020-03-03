using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int a = 1; a < 10; a++)
                for (int b = 1; b < 10; b++)
                    for (int c = 1; c < 10; c++)
                        for (int d = 1; d < 10; d++)
                            if ((n % a == 0) && (n % b == 0) && (n % c == 0) && (n % d == 0))
                            {
                                Console.Write(a);
                                Console.Write(b);
                                Console.Write(c);
                                Console.Write(d);
                                Console.Write(" ");
                            }
        }
    }
}
