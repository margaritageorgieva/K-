using System;

namespace Задача_2___Тест_1___2_II_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Да се запише според правилата на С# изразът :");

            Console.Write("b="); int b = Int32.Parse(Console.ReadLine());
            Console.Write("y="); int y = Int32.Parse(Console.ReadLine());

           
            double M = (b + Math.Sin(2) * Math.Pow(Math.PI, 4)) /(Math.Sqrt(Math.Pow(Math.Cos(6),1/5))) + Math.Abs((Math.Sin(y) / Math.Cos(y)));

            Console.WriteLine("Резултатът е равен на:" +M);

           

        }
    }
}
