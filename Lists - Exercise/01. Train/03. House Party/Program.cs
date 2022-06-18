using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string input = Console.ReadLine();
                string[] str = input.Split();
                if (str.Length == 3)
                {
                    if (!names.Contains(str[0]))
                    {
                        names.Add(str[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{str[0]} is already in the list!");
                    }
                }
                else
                {
                    if (names.Contains(str[0]))
                    {
                        names.Remove(str[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{str[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(String.Join("\n", names));
        }
    }
}
