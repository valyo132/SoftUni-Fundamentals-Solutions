using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> contenders = Console.ReadLine().Split(", ").ToList();

            Dictionary<string, int> racersAndDistance = new Dictionary<string, int>();

            string lettersPattern = @"(?<letters>[A-Za-z])";
            string numbersPattern = @"(?<numbers>[0-9])";

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of race")
                {
                    break;
                }

                string name = "";
                MatchCollection matchesLetters = Regex.Matches(command, lettersPattern);

                foreach (Match match in matchesLetters)
                {
                    name += match.ToString();
                }

                if (contenders.Contains(name))
                {
                    int distance = 0;
                    MatchCollection matchesNumbers = Regex.Matches(command, numbersPattern);

                    foreach (Match match in matchesNumbers)
                    {
                        distance += int.Parse(match.ToString());
                    }

                    if (!racersAndDistance.ContainsKey(name))
                    {
                        racersAndDistance.Add(name, distance);
                    }
                    else
                    {
                        racersAndDistance[name] += distance;
                    }
                }
            }

            var orderedResults = racersAndDistance.OrderByDescending(x => x.Value).ToList();

            Console.WriteLine($"1st place: {orderedResults[0].Key}");
            Console.WriteLine($"2nd place: {orderedResults[1].Key}");
            Console.WriteLine($"3rd place: {orderedResults[2].Key}");
        }
    }
}
