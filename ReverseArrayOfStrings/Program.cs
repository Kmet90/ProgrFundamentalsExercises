using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(' ')                
                .ToArray();

            string[] reversed = arr.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
