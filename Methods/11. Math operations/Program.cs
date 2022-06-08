using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, command, secondNumber)); 
        }
        static double Calculate(int firstNumber, string command, int secondNumber)
        {
            double result = 0;
            switch (command)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
            }
            return result;
        }
    }
}
