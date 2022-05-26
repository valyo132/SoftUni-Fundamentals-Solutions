using System;

namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = int.Parse(Console.ReadLine());
            double kilometers = meters / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
