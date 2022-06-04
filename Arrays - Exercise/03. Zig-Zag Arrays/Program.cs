using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int[] leftLine = new int[countOfLines];
            int [] rigthLine = new int[countOfLines];

            for (int i = 1; i <= countOfLines; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    leftLine[i - 1] = numbers[0];
                    rigthLine[i - 1] = numbers[1];
                }
                else
                {
                    rigthLine[i - 1] = numbers[0];
                    leftLine[i - 1] = numbers[1];
                }
            }

            for (int i = 0; i < leftLine.Length; i++)
            {
                Console.Write($"{leftLine[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < rigthLine.Length; i++)
            {
                Console.Write($"{rigthLine[i]} ");
            }
        }
    }
}
