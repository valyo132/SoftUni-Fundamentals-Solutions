using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double result = (double)countOfPeople / (double)capacity;

            Console.WriteLine(Math.Ceiling(result));
        }
    }
}
