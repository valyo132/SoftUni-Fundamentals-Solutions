using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            MultiplicationSign(firstNumber, secondNumber, thirdNumber);
        }
        static void MultiplicationSign(int firstNumber, int secondNumber, int thirdNumber)
        {
            int count = 0;
            if (firstNumber < 0) count++;
            if (secondNumber < 0) count++;
            if (thirdNumber < 0) count++;

            if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                Console.WriteLine("positive");
            }
            else if (count == 1 || count == 3)
            {
                Console.WriteLine("negative");
            }
            if (count == 2)
            {
                Console.WriteLine("positive");
            }
            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("zero");
            }

        }
    }
}
