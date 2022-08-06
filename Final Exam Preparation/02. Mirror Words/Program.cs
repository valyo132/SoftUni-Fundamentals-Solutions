using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([#@])(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";

            var validPairs = new Dictionary<string, string>();
            var pairsToPrint = new List<string>();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["word1"].Value.ToString();
                string secondWord = match.Groups["word2"].Value.ToString();

                string reversedWord = "";
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    reversedWord += secondWord[i];
                }

                if (firstWord == reversedWord)
                {
                    validPairs.Add(firstWord, secondWord);
                }
            }

            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if (validPairs.Count > 0)
            {
                foreach (var pair in validPairs)
                {
                    string validPair = $"{pair.Key} <=> {pair.Value}";
                    pairsToPrint.Add(validPair);
                
                }

                Console.WriteLine("The mirror words are:");

                Console.WriteLine(string.Join(", ", pairsToPrint));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
