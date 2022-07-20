using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> midexList = new List<int>();

            List<int> remainedNumbers = new List<int>();
            if (firstList.Count > secondList.Count)
            {
                remainedNumbers.Add(firstList[firstList.Count - 1]);
                remainedNumbers.Add(firstList[firstList.Count - 2]);

                firstList.RemoveRange(firstList.Count - 2, 2);
            }
            else
            {
                remainedNumbers.Add(secondList[0]);
                remainedNumbers.Add(secondList[1]);

                secondList.RemoveRange(0, 2);
            }

            secondList.Reverse();
            for (int i = 0; i < firstList.Count; i++)
            {
                midexList.Add(firstList[i]);
                midexList.Add(secondList[i]);
            }

            remainedNumbers = remainedNumbers.OrderBy(x => x).ToList();

            var result = midexList.OrderBy(x => x).Where(y => y > remainedNumbers[0] && y < remainedNumbers[1]).ToList();
            Console.WriteLine(String.Join(' ', result));
        }
    }
}
