using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] token = input.Split();

                switch (token[0])
                {
                    case "Delete":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == int.Parse(token[1]))
                            {
                                numbers.Remove(int.Parse(token[1]));
                                i = 0;
                            }
                        }
                        break;
                    case "Insert":
                        int numberToBeInsterted = int.Parse(token[1]);
                        int index = int.Parse(token[2]);
                        numbers.Insert(index, numberToBeInsterted);
                        break;
                }
            }
            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
