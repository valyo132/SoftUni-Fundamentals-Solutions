using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var listOfWords = new List<string>();

            var capitalAndLength = new Dictionary<char, int>();

            string capitalLetterPattern = @"(?<symbol>[#$%&*])(?<letters>[A-Z]+)\1";
            var lettersMatch = Regex.Match(input, capitalLetterPattern);
            char[] allCapitalLetters = lettersMatch.Groups["letters"].Value.ToString().ToCharArray();

            string wordLenthPattern = @"(?<code>[0-9]+):(?<length>[0-9]{2})";
            MatchCollection matches = Regex.Matches(input, wordLenthPattern);
            for (int i = 0; i < matches.Count; i++)
            {
                int currASCIIcode = int.Parse(matches[i].Groups["code"].Value.ToString());

                char currLetter = (char)currASCIIcode;
                int currWordLenght = int.Parse(matches[i].Groups["length"].Value.ToString()) + 1;

                if (!capitalAndLength.ContainsKey(currLetter))
                {
                    capitalAndLength.Add(currLetter, currWordLenght);
                }
            }

            List<string> allWords = input.Split('|')[2].Split().ToList();
            for (int i = 0; i < allCapitalLetters.Length; i++)
            {
                char letterToFind = allCapitalLetters[i];
                int lenght = capitalAndLength[letterToFind];

                for (int k = 0; k < allWords.Count; k++)
                {
                    string currWord = allWords[k];
                    if (currWord[0] == letterToFind && currWord.Length == lenght)
                    {
                        listOfWords.Add(currWord);
                    }
                }
            }

            foreach (var word in listOfWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
