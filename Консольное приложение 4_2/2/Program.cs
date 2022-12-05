using System;

namespace _2
{
    class Program
    {
        static void P(int max, int n)
        {
            if (n <=max )
            {
                for (int i = 1; i<= n; i++)
                    Console.Write(n + " ");
                Console.WriteLine();
                P(max, n + 1);
            }
        }
        static void Main(string[] args)
        {
            int n = 1;
            int max;
            while (true)
            {
                try
                {
                    Console.Write("Введите максимальное число последовательности: ");
                    max = int.Parse(Console.ReadLine());
                    if (max < 1)
                    {
                        Console.WriteLine("Число должно быть положительным");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!!!");
                }
            }   
           P(max,n);
        }
    }
}
