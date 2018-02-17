using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "A")
                {
                    if (phonebook.ContainsKey(input[1]) == false)
                    {
                        phonebook.Add(input[1], input[2]);
                    }
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                }
                else if (input[0] == "END")
                {
                    break;
                }
            }
        }
    }
}
