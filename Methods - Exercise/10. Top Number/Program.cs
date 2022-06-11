using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            TopNumber(number);
        }

        static void TopNumber(int number)
        {

            for (int i = 1; i <= number; i++)
            {
                int copyNumber = i;
                int sum = 0;
                bool oddDigit = false;
                while (copyNumber > 0)
                {
                    sum += copyNumber % 10;
                    if ((copyNumber % 10) % 2 != 0)
                    {
                        oddDigit = true;
                    }
                    copyNumber /= 10;
                }

                if (oddDigit && sum % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
