using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            SmallestOfThreeNumbers(firstNumber, secondNumber, thirdNumber);
        }

        static void SmallestOfThreeNumbers(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber < secondNumber)
            {
                if (firstNumber < thirdNumber)
                {
                    Console.WriteLine(firstNumber);
                }
                else
                {
                    Console.WriteLine(thirdNumber);
                }
            }
            else if (secondNumber < thirdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
