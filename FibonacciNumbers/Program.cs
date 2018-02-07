using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FibonacciSum(n);
        }

        private static void FibonacciSum(int n)
        {
            int first = 1;
            int second = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            Console.WriteLine(second);
        }
    }
}
