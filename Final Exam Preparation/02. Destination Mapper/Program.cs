using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> allPlaces = new List<string>();

            string input = Console.ReadLine();
            string pattern = @"([=\/])(?<place>[A-Z]{1}[A-Za-z]{2,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            int travelPoints = 0;
            foreach (Match match in matches)
            {
                string currPlace = match.Groups["place"].Value.ToString();
                allPlaces.Add(currPlace);

                travelPoints += currPlace.Length;
            }

            Console.WriteLine("Destinations: " + String.Join(", ", allPlaces));

            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
