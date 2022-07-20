using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string str = Console.ReadLine();
            List<char> strToList = str.ToList();

            var messege = new List<char>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int sumToFindIndex = 0;
                char partOfTheMessege = ' ';
                while (numbers[i] > 0)
                {
                    sumToFindIndex += numbers[i] % 10;
                    numbers[i] /= 10;
                }
                if (sumToFindIndex > strToList.Count - 1)
                {
                    sumToFindIndex -= strToList.Count - 1;
                    partOfTheMessege = strToList[sumToFindIndex - 1];
                }
                else
                {
                    partOfTheMessege = strToList[sumToFindIndex];
                }
                messege.Add(partOfTheMessege);
                strToList.RemoveAt(sumToFindIndex - 1);
            }
            foreach (var item in messege)
            {
                Console.Write(item);
            }
        }
    }
}
