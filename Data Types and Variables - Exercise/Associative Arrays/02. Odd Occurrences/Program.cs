using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');

            foreach (var word in words)
            {
                if (!keyValuePairs.ContainsKey(word))
                {
                    keyValuePairs.Add(word, 1);
                }
                else
                {
                    keyValuePairs[word]++;
                }
            }

            foreach (var pair in keyValuePairs)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write($"{pair.Key} ");
                }
            }
        }
    }
}
