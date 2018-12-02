using System;
using System.Collections.Generic;
using System.Linq;

namespace Задача_5_зад._377_2
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Да се въведат от клавиатурата 13 числа.Да се намери и отпечата средноаритметичното на тези от тях, които са: положителни или по-малки от - 300");
            List<int> numbers = new List<int>();
            int avg = 0;
            Console.WriteLine("Въведете 13 числа:");
            for (int i = 0; i < 13; i++)
            {

                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > 0 || currentNum < -300)
                {
                    numbers.Add(currentNum);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;

            avg = numbers.Sum() / numbers.Count;
            Console.Write("Средно аритметично: " + avg);

            Console.ResetColor();

        }
    }
}
