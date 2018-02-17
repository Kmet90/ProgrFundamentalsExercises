using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(s => int.Parse(s))
                .ToArray();
            bool isSum = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++) 
                {
                    int a = numbers[i];
                    int b = numbers[j];
                    int sum = a + b;

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        isSum = false;
                    }
                }
            }

            if (isSum)
            {
                Console.WriteLine("No");
            }

        }
    }
}
