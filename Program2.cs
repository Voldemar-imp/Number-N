using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Random random = new Random();
            int minNumber = 1;
            int maxNumber = 27;
            int number = random.Next(minNumber, (maxNumber + 1));            
            int minValue = 100;
            int maxValue = 999;
            int total = 0;

            Console.WriteLine("Выпало число: " + number);  

            for (int i = number; i <= maxValue; i += number)
            {
                if (i >= minValue && i <= maxValue)
                {
                    total ++;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Количество количество трехзначных натуральных чисел, " +
                "которые кратны {0}, равно {1}", number ,total);
        }
    }
}
