using System;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Превърнете в 2 , 8 и 16 инча числото: 2077 .");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Двоична - 100000011101 ; Осмична - 4035 ; Шестнадесетична - 81D ");
            Console.ResetColor();
           
            int value = 2077;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
            string binary2 = Convert.ToString(value, 8);
            Console.WriteLine(binary2);
            string binary3 = Convert.ToString(value, 16);
            Console.WriteLine(binary3);



           
        }
    }
}
