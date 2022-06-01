using System;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] StringNumbers = input.Split(' ');

            int[] numbers = new int[StringNumbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(StringNumbers[i]);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
