using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToList();          
           
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numbersToTake = commands[0];
            int numbersToDelete = commands[1];
            int numberInList = commands[2];

            bool hasNumber = numbers
                .Take(numbersToTake)
                .Skip(numbersToDelete)
                .Any(x => x == numberInList);

            Console.WriteLine(hasNumber ? "YES!" : "NO!");
        }
    }
}
