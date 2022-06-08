using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int even = GetSumOfEvenDigits(number);
            int odd = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(even, odd);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvenDigits = 0;
            int digit = number;
            while (digit > 0)
            {
                int current = digit % 10;
                if (current % 2 == 0)
                {
                    sumOfEvenDigits += current;
                }
                digit = digit / 10;
            }
            return sumOfEvenDigits;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOfOddDigits = 0;
            int digit = number;
            while (digit > 0)
            {
                int current = digit % 10;
                if (current % 2 != 0)
                {
                    sumOfOddDigits += current;
                }
                digit = digit / 10;
            }
            return sumOfOddDigits;
        }

        static int GetMultipleOfEvenAndOdds(int sumOfEvenDigits, int sumOfOddDigits)
        {
            return sumOfEvenDigits * sumOfOddDigits;
        }
    }
}
