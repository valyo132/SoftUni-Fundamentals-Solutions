using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentString = input[i];

                char beforeNumber = currentString[0];
                char afterNumber = currentString[currentString.Length - 1];
                double number = double.Parse(currentString.Substring(1, currentString.Length - 2));

                int firstNumberPosition = char.ToUpper(beforeNumber) - 64;

                if (char.IsUpper(beforeNumber))
                {
                    number /= firstNumberPosition;
                }
                else
                {
                    number *= firstNumberPosition;
                }

                int secondNumberPosition = char.ToUpper(afterNumber) - 64;

                if (char.IsUpper(afterNumber))
                {
                    number -= secondNumberPosition;
                }
                else
                {
                    number += secondNumberPosition;
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
