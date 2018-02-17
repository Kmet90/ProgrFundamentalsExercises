using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "Delete")
                {
                    int num = int.Parse(command[1]);
                    numbers.RemoveAll(n => n == num);
                }
                else if (command[0] == "Insert")
                {
                    int num = int.Parse(command[1]);
                    int pos = int.Parse(command[2]);
                    numbers.Insert(pos, num);
                }
                else if (command[0] == "Even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if (command[0] == "Odd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }


            }
        }
    }
}
