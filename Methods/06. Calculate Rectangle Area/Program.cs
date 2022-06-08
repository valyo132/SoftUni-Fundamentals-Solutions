using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculation(a, b)); 
        }
        static int Calculation(int a, int b)
        {
            return a * b;
        }
    }
}
