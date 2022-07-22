using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfMesseges = int.Parse(Console.ReadLine());

            string findKeyCount = @"[starSTAR]";
            string pattern = @"@(?<planetName>[A-Z][a-z]+)[^@\-,!:>]*?:(?<number>[0-9]+)[^@\-,!:>]*?!(?<attack>[A-Z]{1})![^@\-,!:>]*?->(?<peopleCount>[0-9]+)";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < countOfMesseges; i++)
            {
                string encryptedMessege = Console.ReadLine();

                MatchCollection matches = Regex.Matches(encryptedMessege, findKeyCount);
                int keyCount = matches.Count;

                string decryptedMessege = "";
                for (int k = 0; k < encryptedMessege.Length; k++)
                {
                    decryptedMessege += (char)(encryptedMessege[k] - keyCount);
                }

                if (Regex.IsMatch(decryptedMessege, pattern))
                {
                    Match match = Regex.Match(decryptedMessege, pattern);

                    string planetName = match.Groups["planetName"].Value;
                    long population = long.Parse(match.Groups["number"].Value);
                    string typeOfTheAttack = match.Groups["attack"].Value;
                    int soildersCount = int.Parse(match.Groups["peopleCount"].Value);

                    if (typeOfTheAttack == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (typeOfTheAttack == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
