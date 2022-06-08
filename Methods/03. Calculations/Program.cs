using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 60/100

            string command = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(firstNumber,secondNumber);
            }
            else if (command == "multiply")
            {
                Multyply(firstNumber, secondNumber);
            }
            else if (command == "subtract")
            {
                Subtract(firstNumber, secondNumber);
            }
            else if (command == "divide")
            {
                Divide(firstNumber, secondNumber);
            }
        }

        static void Add(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
        static void Multyply(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }
        static void Divide(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
        static void Subtract(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
    }
}
