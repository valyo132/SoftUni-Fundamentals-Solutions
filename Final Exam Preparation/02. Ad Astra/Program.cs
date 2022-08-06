using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int totalCalories = 0;

            string pattern = @"([#|])(?<product>[A-Z][a-z]+|[A-Z][a-z]+ [A-Z][a-z]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]+)\1";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }

            int daysWithFood = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {daysWithFood} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["product"]}, Best before: {match.Groups["date"]}, Nutrition: {match.Groups["calories"]}");
            }
        }
    }
}
