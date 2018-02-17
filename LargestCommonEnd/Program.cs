using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Split(' ').ToArray();
            string[] words2 = Console.ReadLine().Split(' ').ToArray();

            int leftCount = 0;
            int rightCount = 0;
            int arrLength = Math.Min(words1.Length, words2.Length);

            for (int i = 0; i < arrLength; i++)
            {
                if (words1[i] == words2[i]) 
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < arrLength; i++)
            {
                if (words1[words1.Length - i - 1] == words2[words2.Length - i - 1]) 
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }

            if (leftCount>rightCount)
            {
                Console.WriteLine(leftCount);
            }
            else
            {
                Console.WriteLine(rightCount);
            }

        }
    }
}
