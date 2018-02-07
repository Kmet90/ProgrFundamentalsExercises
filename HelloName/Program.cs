using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            SayHello(name);
        }

        static void SayHello(string name)
        {

            Console.WriteLine($"Hello, {name}!");
        }
    }
}
