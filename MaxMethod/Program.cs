using System;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxNumber = GetMax(a, b, c);
            Console.WriteLine(maxNumber);
        }

        static int GetMax(int a, int b, int c)
        {
            if (a <= b)
            {
                a = b;
            }
            if (a <= c)
            {
                a = c;
            }

            return a;

        }
    }
}
