using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string trueORfalse = Console.ReadLine().ToLower();

            bool boolean = Convert.ToBoolean(trueORfalse);

            if (boolean)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
