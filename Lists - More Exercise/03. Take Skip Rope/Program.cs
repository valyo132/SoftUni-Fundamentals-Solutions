using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            string input = Console.ReadLine();

            var numbersList = input.Where(x => char.IsDigit(x))
                .Select(x => int.Parse(x.ToString()))
                .ToList();
            var nonNumbersList = input.Where(x => !char.IsDigit(x))
                .Select(x => x.ToString())
                .ToList();

            var takeList = new List<int>();
            var skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            int skipIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                var temp = new List<string>(nonNumbersList);

                temp = temp.Skip(skipIndex).Take(takeList[i]).ToList();
                result.Append(String.Join("", temp));

                skipIndex += takeList[i] + skipList[i];
            }

            Console.WriteLine(result.ToString());
        }
    }
}
