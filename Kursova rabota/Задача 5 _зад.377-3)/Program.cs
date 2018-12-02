using System;
using System.Collections.Generic;

namespace Задача_5__зад._377_3_
{
    class Program
    {
     
            static int Pro(int k)
            {
            Console.WriteLine("Да се създаде метод Pro(k) , който генерира k на брой случайни цели числа и като резултат връща произведението на тези от тях, които са в интервала [-10,10].В главния метод да се въведат 3 цели положителни числа a,b и c. Да се намери:Pro(|a-b|)*Pro(c)");
            Random rand = new Random();
            List<int> numbers = new List<int>();
            int result = 1;

            for (int i = 0; i < k; i++)
            {
                int currentNum = rand.Next(-100, 100);

                if (currentNum > -10 && currentNum < 10)
                {
                    numbers.Add(currentNum);
                }
            }

            foreach (int num in numbers)
            {
                result *= num;
            }

            return result;
        }

        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;
            int c = 30;

            Console.WriteLine(Pro(Math.Abs(a - b)) * Pro(c));

        }
      }
    }

