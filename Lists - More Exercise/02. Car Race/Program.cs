using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int middleIndex = numbers.Count / 2;

            double sumOfFirstCar = 0;
            for (int i = 0; i < middleIndex; i++)
            {
                if (numbers[i] > 0)
                {
                    sumOfFirstCar += numbers[i];
                }
                else
                {
                    sumOfFirstCar *= 0.8;
                }
            }
            numbers.Reverse();

            double sumOfSecondCar = 0;
            for (int i = 0; i < middleIndex; i++)
            {
                if (numbers[i] > 0)
                {
                    sumOfSecondCar += numbers[i];
                }
                else
                {
                    sumOfSecondCar *= 0.8;
                }
            }

            if (sumOfFirstCar < sumOfSecondCar)
            {
                Console.WriteLine($"The winner is left with total time: {sumOfFirstCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumOfSecondCar}");
            }
        }
    }
}
