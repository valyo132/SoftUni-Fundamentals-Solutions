using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            int remainedNumber = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                int currNumberToMultiply = int.Parse(firstNumber[i].ToString());
                int result = currNumberToMultiply * secondNumber + remainedNumber;
                sb.Append(result % 10);
                remainedNumber = result / 10;
            }
            if (remainedNumber > 0)
            {
                sb.Append(remainedNumber);
            }

            char[] resultToCharArray = sb.ToString().ToCharArray();

            Array.Reverse(resultToCharArray);

            Console.WriteLine(resultToCharArray);
        }
    }
}
