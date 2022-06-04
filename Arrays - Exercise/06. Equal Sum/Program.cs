using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int middleInteger = numbers.Length / 2;
            bool flag = true;

            for (int k = 0; k < numbers.Length; k++)
            {
                int rightSum = 0, leftSum = 0;
                for (int i = k + 1; i < numbers.Length; i++)
                {
                    leftSum += numbers[i];
                }

                for (int i = k - 1; i >= 0; i--)
                {
                    rightSum += numbers[i];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(k);
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("no");
            }
        }
    }
}
