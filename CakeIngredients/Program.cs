using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 1; i <= 20; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!") 
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter = i;
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
