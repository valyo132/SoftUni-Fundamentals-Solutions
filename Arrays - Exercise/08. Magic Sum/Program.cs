using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int wantedNumber = int.Parse(Console.ReadLine());

            for (int k = 0; k < numbers.Length; k++)
            {
                for (int i = k + 1; i < numbers.Length; i++)
                {
                    if (numbers[k] + numbers[i] == wantedNumber)
                    {
                        Console.WriteLine($"{numbers[k]} {numbers[i]}");
                    }
                }
            }
        }
    }
}
