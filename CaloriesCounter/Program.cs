using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int kcal = 0;
            int totalKcal = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        kcal = 500;
                        totalKcal += kcal;
                        break;
                    case "tomato sauce":
                        kcal = 150;
                        totalKcal += kcal;
                        break;
                    case "salami":
                        kcal = 600;
                        totalKcal += kcal;
                        break;
                    case "pepper":
                        kcal = 50;
                        totalKcal += kcal;
                        break;
                    default:
                        kcal = 0; break;
                }
            }
            Console.WriteLine($"Total calories: {totalKcal}");
        }
    }
}
