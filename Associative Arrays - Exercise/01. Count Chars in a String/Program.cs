using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().Where(letter => letter != ' ').ToArray();

            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!occurrences.ContainsKey(chars[i]))
                {
                    occurrences.Add(chars[i], 1);
                }
                else
                {
                    occurrences[chars[i]]++;
                }
            }

            foreach (var pair in occurrences)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
