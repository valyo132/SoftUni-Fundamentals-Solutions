using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> occurencesByNumber = new SortedDictionary<double, int>();

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (occurencesByNumber.ContainsKey(number))
                {
                    occurencesByNumber[number]++;
                }
                else
                {
                    occurencesByNumber.Add(number, 1);
                }
            }

            foreach (var pair in occurencesByNumber)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
