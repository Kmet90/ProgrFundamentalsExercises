using System;

namespace LastK_NumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int startIndex = Math.Max(0, i - k);

                for (int j = startIndex; j < i; j++) 
                {
                    sum += arr[j];
                }

                arr[i] = sum;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
