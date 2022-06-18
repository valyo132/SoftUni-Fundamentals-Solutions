using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    internal class Program
    {
        // 83/100
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] tokens = input.Split();

                switch (tokens[0])
                {
                    case "Add":
                        AddToList(numbers, tokens);
                        break;
                    case "Insert":
                        InsertToList(numbers, tokens);
                        break;
                    case "Remove":
                        RemoveFromList(numbers, tokens);
                        break;
                }
                switch (tokens[1])
                {
                    case "left":
                        ShiftLeftInList(numbers, tokens);
                        break;
                    case "right":
                        ShiftRightInList(numbers, tokens);
                        break;
                }
            }
            Console.WriteLine(String.Join(' ', numbers));
        }

        private static void ShiftRightInList(List<int> numbers, string[] tokens)
        {
            int countOfShifting = int.Parse(tokens[2]);
            for (int i = 0; i < countOfShifting; i++)
            {
                int LastToFirst = numbers[numbers.Count - 1];
                numbers.Remove(LastToFirst);
                numbers.Insert(0, LastToFirst);
            }
        }

        private static void ShiftLeftInList(List<int> numbers, string[] tokens)
        {
            int countOfShifting = int.Parse(tokens[2]);
            for (int i = 0; i < countOfShifting; i++)
            {
                int firtsToLast = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firtsToLast);
            }
        }

        private static void RemoveFromList(List<int> numbers, string[] tokens)
        {
            int indexToBeRemoved = int.Parse(tokens[1]);
            if (indexToBeRemoved > numbers.Count || indexToBeRemoved < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(indexToBeRemoved);
            }
        }

        private static void InsertToList(List<int> numbers, string[] tokens)
        {
            int index = int.Parse(tokens[2]);
            int numberToBeInserted = int.Parse(tokens[1]);
            if (index > numbers.Count || numberToBeInserted < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(index, numberToBeInserted);
            }
        }

        private static void AddToList(List<int> numbers, string[] tokens)
        {
            int number = int.Parse(tokens[1]);
            numbers.Add(number);
        }
    }
}
