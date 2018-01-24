using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int productVolume = int.Parse(Console.ReadLine());
            int productEnergy = int.Parse(Console.ReadLine());
            int productSugar = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:", productVolume, productName);
            Console.WriteLine("{0}kcal, {1}g sugars", (double)(productEnergy * productVolume / 100.0), 
                                                      (double)(productSugar * productVolume / 100.0));
        }
    }
}
