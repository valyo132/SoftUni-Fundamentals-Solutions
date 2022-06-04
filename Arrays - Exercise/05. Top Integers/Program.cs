using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                while (count < numbers.Length - 1 - i)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count == numbers.Length - (i + 1))
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
