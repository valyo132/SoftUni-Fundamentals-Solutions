using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contestAndItsPassword = new Dictionary<string, string>();

            while (true)
            {
                string[] contests = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                if (contests[0] == "end of contests")
                {
                    break;
                }
                string newContest = contests[0];
                string passwordForContest = contests[1];

                contestAndItsPassword.Add(newContest, passwordForContest);
            }

            var userAndContests = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] submissions = Console.ReadLine().Split("=>");
                if (submissions[0] == "end of submissions")
                {
                    break;
                }

                string currContest = submissions[0];
                string passowrd = submissions[1];
                string currUsername = submissions[2];
                int points = int.Parse(submissions[3]);


                if (contestAndItsPassword.ContainsKey(currContest) && contestAndItsPassword[currContest] == passowrd)
                {
                    if (!userAndContests.ContainsKey(currUsername))
                    {
                        userAndContests.Add(currUsername, new Dictionary<string, int>());
                        userAndContests[currUsername].Add(currContest, points);
                    }
                    if (userAndContests[currUsername].ContainsKey(currContest))
                    {
                        if (userAndContests[currUsername][currContest] < points)
                        {
                            userAndContests[currUsername][currContest] = points;
                        }
                    }
                    else
                    {
                        userAndContests[currUsername].Add(currContest, points);
                    }
                }
            }

            var totalPointsOfUser = new Dictionary<string, int>();

            foreach (var user in userAndContests)
            {
                totalPointsOfUser[user.Key] = userAndContests[user.Key].Values.Sum();
            }

            string winner = totalPointsOfUser.Keys.Max();
            int mostPoints = totalPointsOfUser.Values.Max();
            foreach (var person in totalPointsOfUser)
            {
                if (person.Value == mostPoints)
                {
                    Console.WriteLine($"Best candidate is {person.Key} with total {person.Value} points.");
                }
            }

            Console.WriteLine("Ranking:");

            foreach (var name in userAndContests.OrderBy(x => x.Key))
            {
                Console.WriteLine(name.Key);
                foreach (var points in name.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }
        }
    }
}
