using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());


            for (int i = 2; i <= value; i++)
            {
                if (value % i == 0)
                {

                    Console.WriteLine($"Найменьший делитель равен: {i}.");
                    break;
                }
            }
        }
    }
}
