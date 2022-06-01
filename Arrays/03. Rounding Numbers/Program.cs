using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            double[] realNumbers = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                realNumbers[i] = double.Parse(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{realNumbers[i]} => {(int)Math.Round(realNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
