using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNmber = double.Parse(Console.ReadLine());
            double secondNmber = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Factorial(firstNmber, secondNmber):f2}") ;
        }

        static double Factorial(double firstNumber, double secondNumber)
        {
            double fac1 = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                fac1 *= i;
            }

            double fac2 = 1;
            for (int i = 1; i <= secondNumber; i++)
            {
                fac2 *= i;
            }

            double result = fac1 / fac2;
            return result;
        }
    }
}
