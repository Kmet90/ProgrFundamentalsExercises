using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
