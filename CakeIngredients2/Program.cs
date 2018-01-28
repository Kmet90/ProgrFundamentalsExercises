using System;

namespace CakeIngredients2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int counter = 0;
            while (ingredient != "Bake!") 
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
                if (counter==20)
                {
                    break;
                }
                else
                {
                    ingredient = Console.ReadLine();
                }
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
