using System;
using System.Linq;

namespace Задача_6__зад._408
{
    class Program
    {
        private static int i;

        static void Main()
        {
            Console.WriteLine("1.Да се направят два метода :");
            Console.WriteLine("а) за въвеждане на едномерен масив от реални числа;");
            Console.WriteLine("б) за изчисляване на средноаритметичното на тези елементи на масива , които принадлежат на интервала [-100,100].");
            Console.Write("2. В главния метод въведете цяло число  и три едномерни масива . За всеки масив изчислете и отпечатайте стойността на средноаритметичното то точка 1б." +
            "Намерете и отпечатайте максималната от трите средноаритметични стойности.");

            Console.WriteLine("a)");
            Console.WriteLine("Въведете n :");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++) ;
            {

                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
            Average(a);

            double[] A = new double[n];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("A[" + i + "]=");
                A[i] = double.Parse(Console.ReadLine());
            }
            double averageA = A.Average();

            Console.WriteLine("Средното аритметично на масива А е:" + averageA);
            double[] B = new double[n];
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write("B[" + i + "]=");
                B[i] = double.Parse(Console.ReadLine());
            }
            double averageB = B.Average();

            Console.WriteLine("Средното аритметично на масива B е:" + averageB);

            double[] C = new double[n];
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write("C[" + i + "]=");
                C[i] = double.Parse(Console.ReadLine());
            }
            double averageC = C.Average();

            Console.WriteLine("Средното аритметично на масива С е:" + averageC);
            if (averageA > averageB && averageA > averageC)
            {
                Console.WriteLine("Максималната стойност от средноаритметичните на трите масива е" + averageA);
            }
            else if (averageB > averageA && averageB > averageC)
            {
                Console.WriteLine("Максималната стойност от средноаритметичните на трите масива е" + averageB);
            }
            else if (averageC > averageA && averageC > averageB)
            {
                Console.WriteLine("Максималната стойност от средноаритметичните на трите масива е" + averageC);
            }

        }
        static void Average(int[] a)
        {
            double sum = 0;
            double number = 0;
            double avrg = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > -100 && a[i] < 100)
                {
                    sum = sum + a[i];
                    number = number + 1;
                }
            }
            avrg = sum / number;
            Console.WriteLine("Средното аритметично на масива е:" + avrg);
            if (avrg > -100 && avrg < 100)
            {
                Console.WriteLine("Средното аритметично е в интервала [-100,100]");
            }
            else if (avrg < -100 && avrg > 100)
            {
                Console.WriteLine("Средното аритметично  HE е в интервала [-100,100]");
            }
            
            











        }
    }
}














        

