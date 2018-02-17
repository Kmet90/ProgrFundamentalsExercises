using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[arr.Length];

            for (int i = 0; i < k; i++) 
            {
                int[] rotated = new int[arr.Length];
                rotated[0] = arr[arr.Length - 1];
                for (int j = 1; j < rotated.Length; j++)
                {
                    rotated[j] = arr[j - 1];
                }

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += rotated[j];
                }
                arr = rotated;
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
