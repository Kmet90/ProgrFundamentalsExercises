using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                
                int quantity = int.Parse(Console.ReadLine());
                bool keyIsContained = resources.ContainsKey(resource);

                if (keyIsContained == false)
                {
                    resources.Add(resource, 0);
                }
                resources[resource] = resources[resource] + quantity;
            }
            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }            
        }
    }
}
