using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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
                    Console.WriteLine(String.Join(" ", numbers));
                    break;
                }
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        int number = int.Parse(command[1]);
                        numbers.Add(number);
                        break;
                    case "Remove":
                        int removedNumber = int.Parse(command[1]);
                        numbers.Remove(removedNumber);
                        break;
                    case "RemoveAt":
                        int removedNumberByIndex = int.Parse(command[1]);
                        numbers.RemoveAt(removedNumberByIndex);
                        break;
                    case "Insert":
                        int index = int.Parse(command[1]);
                        int numberToAdd = int.Parse(command[2]);
                        numbers.Insert(numberToAdd, index);
                        break;
                }
            }
        }
    }
}
