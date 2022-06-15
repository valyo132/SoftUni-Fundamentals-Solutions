using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> firstNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> secondNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int biggerList = 0;
            if (firstNumbers.Count > secondNumbers.Count)
            {
                biggerList = firstNumbers.Count;
            }
            else
            {
                biggerList = secondNumbers.Count;
            }

            List<double> resultList = new List<double>();
            for (int i = 0; i < biggerList; i++)
            {
                if (i < firstNumbers.Count)
                {
                    resultList.Add(firstNumbers[i]);
                }
                if (i < secondNumbers.Count)
                {
                    resultList.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", resultList));
        }
    }
}
