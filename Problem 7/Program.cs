using System;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Въвеждаме сума
            int amount = int.Parse(Console.ReadLine());
            //Сума на банкноти
            int count = 0;
            //Банкноти, с които разполагаме
            int[] banknotes = { 100, 50, 20, 10, 5, 1 };
            for (int i = 0; i < banknotes.Length; i++)
            {
                //В отделна променлива разделяме сумата на първата банкнота
                int notes = amount / banknotes[i];
                //От първоначалната сума изваждаме оставащата след делението
                amount = amount - notes*banknotes[i];
                //Броим колко пъти сумата се дели на банкнотата, тоест колко банкноти ни трябват
                count += notes;
            }
            //Отпечатваме колко банкноти ни трябват
            Console.WriteLine(count);
        }
    }
}
