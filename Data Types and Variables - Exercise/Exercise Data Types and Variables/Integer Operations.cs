using System;

namespace Exercise_Data_Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int adding = firstNumber + secondNumber;
            double deviding = adding / thirdNumber;
            double multyplying = deviding * fourthNumber;

            Console.WriteLine(multyplying);
        }
    }
}
