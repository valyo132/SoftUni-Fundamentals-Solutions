using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    if (count > 0)
                    {
                        Console.WriteLine(String.Join(" ", numbers));
                    }
                    break;
                }
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Contains":
                        int IsNumberContains = int.Parse(command[1]);
                        bool contains = numbers.Contains(IsNumberContains);

                        if (contains) { Console.WriteLine("Yes"); }
                        else { Console.WriteLine("No such number"); }
                        break;

                    case "PrintEven":
                        PrintEven(numbers);
                        break;

                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;

                    case "GetSum":
                        GetSum(numbers);
                        break;

                    case "Filter":
                        PrintFilter(numbers, command);
                        Console.WriteLine();
                        break;

                    case "Add":
                        int number = int.Parse(command[1]);
                        numbers.Add(number);
                        count++;
                        break;

                    case "Remove":
                        int removedNumber = int.Parse(command[1]);
                        numbers.Remove(removedNumber);
                        count++;
                        break;

                    case "RemoveAt":
                        int removedNumberByIndex = int.Parse(command[1]);
                        numbers.RemoveAt(removedNumberByIndex);
                        count++;
                        break;

                    case "Insert":
                        int index = int.Parse(command[1]);
                        int numberToAdd = int.Parse(command[2]);
                        numbers.Insert(numberToAdd, index);
                        count++;
                        break;
                }
            }
        }

        private static void PrintEven(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();
        }

        private static void PrintOdd(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();
        }

        static void GetSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        static void PrintFilter(List<int> numbers, string[] command)
        {
            string condition = command[1];
            int num = int.Parse(command[2]);
            if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > num)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
            }
            else if (condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < num)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= num)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= num)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
            }
        }
    }
}
