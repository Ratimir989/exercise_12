using System;

namespace exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число N");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i < N; i++)
            {
                Console.WriteLine($"{i}^{i}={i * i}");
            }
            Console.ReadLine();
        }
    }
}
