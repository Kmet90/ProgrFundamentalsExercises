using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsfNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            int a = 0;
            int b = 0;

            for (int i = firsfNumber; i <= secondNumber; i++)
            {
                for (int j = firsfNumber; j <= secondNumber; j++)
                {
                    if ((i + j) == magicNumber) 
                    {
                        a = i;
                        b = j;
                    }
                    counter++;
                }
            }
            if ((a + b) == magicNumber)
            {
                Console.WriteLine($"Number found! {a} + {b} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
