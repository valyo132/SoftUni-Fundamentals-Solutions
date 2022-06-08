using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            PrintTriangle(end);

        }

        static void Print(int start, int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Print(1, i);
            }
            for (int i = end - 1; i >= 1; i--)
            {
                Print(1, i);
            }
        }
    }
}
