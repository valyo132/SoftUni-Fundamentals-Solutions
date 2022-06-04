using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int countOfSequence = 0, max = 0, digit = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    countOfSequence++;
                    if (countOfSequence > max)
                    {
                        max = countOfSequence;
                        digit = numbers[i];
                    }
                }
                else
                {
                    countOfSequence = 0;
                }
            }
            for (int i = 0; i < max + 1; i++)
            {
                Console.Write($"{digit} ");
            }
        }
    }
}
