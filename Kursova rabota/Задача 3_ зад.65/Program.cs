 using System;

namespace Задача_3__зад._65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лихвеният процент в една страна е бил следният:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Месец:          1   2   3   4   5   6   7   8   9   10  11  12");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Лихвен процент 3.8 3.5 3.5 3.5 4.1 4.1 4.1 4.1 4.9 4.9 4.9 3.8");
            Console.ResetColor();
            Console.WriteLine("Да се състави програма, с която по даден номер на месец да се получава съответния лихвен процент.");

            Console.Write("Enter month number : ");
            int monthnumber = Int32.Parse(Console.ReadLine());
            switch (monthnumber)
            {
                case 1: Console.WriteLine("3.8"); break;
                case 2: Console.WriteLine("3.5"); break;
                case 3: Console.WriteLine("3.5"); break;
                case 4: Console.WriteLine("3.5"); break;
                case 5: Console.WriteLine("4.1"); break;
                case 6: Console.WriteLine("4.1"); break;
                case 7: Console.WriteLine("4.1"); break;
                case 8: Console.WriteLine("4.1"); break;
                case 9: Console.WriteLine("4.9"); break;
                case 10:Console.WriteLine("4.9"); break;
                case 11:Console.WriteLine("4.9"); break;
                case 12:Console.WriteLine("3.8"); break;
             
            }
        }
    }
}
