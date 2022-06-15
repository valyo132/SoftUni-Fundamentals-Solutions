using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                    i = -1;
                }
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            numbers.Reverse();
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
