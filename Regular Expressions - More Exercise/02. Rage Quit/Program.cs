using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            string input = Console.ReadLine().ToUpper();
            string symbolsPattern = @"[^0-9]+";
            string numbersPattern = @"[0-9]+";

            var usedSymbols = new List<char>();

            MatchCollection mathcesSymbols = Regex.Matches(input, symbolsPattern, RegexOptions.IgnoreCase);
            MatchCollection mathcesNumbers = Regex.Matches(input, numbersPattern, RegexOptions.IgnoreCase);

            for (int i = 0; i < mathcesSymbols.Count; i++)
            {
                string currString = mathcesSymbols[i].ToString();
                int timeToRepeat = int.Parse(mathcesNumbers[i].ToString());

                for (int t = 0; t < timeToRepeat; t++)
                {
                    result.Append(currString);
                }

                if (timeToRepeat > 0)
                {
                    for (int k = 0; k < currString.Length; k++)
                    {
                        char currSymbol = currString[k];
                        if (!usedSymbols.Contains(currSymbol))
                        {
                            usedSymbols.Add(currSymbol);
                        }
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {usedSymbols.Count}");
            Console.WriteLine(result.ToString());
        }
    }
}
