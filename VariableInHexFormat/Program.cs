using System;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexadecimalNumber, 16));
        }
    }
}
