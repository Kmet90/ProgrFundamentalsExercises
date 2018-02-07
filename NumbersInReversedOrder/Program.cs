using System;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversedNumber = GetReversedNumber(number);
            Console.WriteLine(reversedNumber);
        }

        static decimal GetReversedNumber(decimal number)
        {
            char[] reverseNumberArray = number.ToString().ToCharArray();
            Array.Reverse(reverseNumberArray);
            return decimal.Parse(new string(reverseNumberArray));
        }    
    }
}
