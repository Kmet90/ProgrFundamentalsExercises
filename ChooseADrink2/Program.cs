using System;

namespace ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double sum = 0.0;

            switch (profession)
            {
                case "Athlete":
                    sum = quantity * 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    sum = quantity * 1.00;
                    break;
                case "SoftUni Student":
                    sum = quantity * 1.70;
                    break;
                default:
                    sum = quantity * 1.20;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {sum:f2}.");
        }
    }
}
