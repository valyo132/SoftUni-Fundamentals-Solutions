using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var allEmojies = new List<string>();
            var coolEmojies = new List<string>();

            string numbersPattern = @"\d";
            string pattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";

            MatchCollection numbers = Regex.Matches(input, numbersPattern);

            BigInteger coolThreshold = 1;
            foreach (var num in numbers)
            {
                int currNumber = int.Parse(num.ToString());

                coolThreshold *= currNumber;
            }

            MatchCollection emojies = Regex.Matches(input, pattern);

            foreach (Match emoji in emojies)
            {
                string currEmoji = emoji.Groups["emoji"].Value.ToString();

                BigInteger emojiCoolnes = 0;
                for (int i = 0; i < currEmoji.Length; i++)
                {
                    emojiCoolnes += currEmoji[i];
                }

                if (emojiCoolnes >= coolThreshold)
                {
                    coolEmojies.Add(emoji.ToString());
                }

                allEmojies.Add(currEmoji);
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            Console.WriteLine($"{allEmojies.Count} emojis found in the text. The cool ones are:");

            foreach (var emoji in coolEmojies)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
