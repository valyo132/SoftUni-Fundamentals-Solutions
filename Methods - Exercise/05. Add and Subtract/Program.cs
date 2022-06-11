using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(SubtractOfNumbers(SumOfNumbers(firstNumber, secondNumber), thirdNumber));
        }

        static double SumOfNumbers(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            return sum;
        }

        static double SubtractOfNumbers(double sum, double thirdNumber)
        {
            double result = sum - thirdNumber;
            return result;
        }
    }
}
