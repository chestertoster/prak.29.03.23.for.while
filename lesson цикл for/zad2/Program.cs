using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Человек в первый день пробежал 10 км. \nКаждый день он увеличивал пробег на 5% В какой день он пробежит 20 км. \nВ какой день сумма пробега будет больше 100 км.");
            
            double p = 10;
            double pSum = 10;
            int pDay = 1;
            int pDayDist = 0;
            int pDaySum = 0;

            while (p < 20 || pSum < 100)
            {
                p *= 1.1;
                pSum += p;
                pDay++;
            
                if (pDayDist == 0 && p > 20) pDayDist = pDay;
                
                if (pDaySum == 0 && pSum > 100) pDaySum = pDay;
                
                Console.WriteLine($"{pDay} день - {p:f3} км, суммарно {pSum:f3} км");
            
            }
            Console.WriteLine($"Человек пробежал больше 20 км за день на {pDayDist} день, а суммарный пробег превысил 100 км на {pDaySum} день.");
        }
    }
}
