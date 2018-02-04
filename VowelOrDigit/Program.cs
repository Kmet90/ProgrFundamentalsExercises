using System;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            switch (input)
            {
                case '0': Console.WriteLine("digit"); break;
                case '1': Console.WriteLine("digit"); break;
                case '2': Console.WriteLine("digit"); break;
                case '3': Console.WriteLine("digit"); break;
                case '4': Console.WriteLine("digit"); break;
                case '5': Console.WriteLine("digit"); break;
                case '6': Console.WriteLine("digit"); break;
                case '7': Console.WriteLine("digit"); break;
                case '8': Console.WriteLine("digit"); break;
                case '9': Console.WriteLine("digit"); break;
                case 'a': Console.WriteLine("vowel"); break;
                case 'e': Console.WriteLine("vowel"); break;
                case 'y': Console.WriteLine("vowel"); break;
                case 'i': Console.WriteLine("vowel"); break;
                case 'o': Console.WriteLine("vowel"); break;
                case 'u': Console.WriteLine("vowel"); break;

                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
