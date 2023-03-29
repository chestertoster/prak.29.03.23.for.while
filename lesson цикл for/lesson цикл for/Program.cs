using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_цикл_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.Write("Напечатать минимальное число, большее 200, которое нацело делится на 17: ");
            value = int.Parse(Console.ReadLine());

            while (value % 17 != 0) value++;

            Console.WriteLine($"Это число: {value}.");
        }
    }
}
