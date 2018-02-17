using System;
using System.Linq;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int length = arr.Length;

            if (length == 1)
            {                
                Console.WriteLine($"{{ {arr[0]} }}");
            }
            else if (length % 2 == 0) 
            {
                int a = arr[length / 2 - 1];
                int b = arr[length / 2];

                Console.WriteLine($"{{ {a}, {b} }}");
            }
            else
            {
                int a = arr[length / 2 - 1];
                int b = arr[length / 2];
                int c = arr[length / 2 + 1];

                Console.WriteLine($"{{ {a}, {b}, {c} }}");
            }
        }
    }
}
