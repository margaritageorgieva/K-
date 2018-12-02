using System;
using System.Collections.Generic;
using System.Linq;

namespace Задача_5__зад._377
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Да се генерира редица от 55 случайни цели числа в интервала [-100,100].Да се отпечатат тези от тях , които са отрицателни");

            Random rng = new Random();
            byte[] bytes = new byte[55];
            int w = 0;

            for (int q = 1; q <= 55; q++)
            {
                w = rng.Next(-100, 100);
                if (w < 0)
                {
                    Console.WriteLine(w);
                }
            }
        }
    }
}
    

