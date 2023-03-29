using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorial(int a)
            {
                if (a == 1)
                {
                    return 1;
                }

                return a * factorial(a - 1);
            }
            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());

            int fact = factorial(value);

            Console.WriteLine($"Факториал {value} равен {fact}.");
        }
    }
}
