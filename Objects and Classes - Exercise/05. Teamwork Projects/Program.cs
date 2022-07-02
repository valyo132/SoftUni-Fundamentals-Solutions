using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 83/100

            int countOfTeams = int.Parse(Console.ReadLine());

            List<Team> teamsToListClass = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                List<string> teamInformation = Console.ReadLine().Split("-").ToList();

                if (teamsToListClass.Any(x => x.TeamName == teamInformation[1]))
                {
                    Console.WriteLine($"Team {teamInformation[1]} was already created!");
                }
                else if (teamsToListClass.Any(x => x.User == teamInformation[0]))
                {
                    Console.WriteLine($"{teamInformation[0]} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamInformation[0], teamInformation[1]);
                    newTeam.Members = new List<string>(); //
                    teamsToListClass.Add(newTeam);

                    Console.WriteLine($"Team {teamInformation[1]} has been created by {teamInformation[0]}!");
                }

            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of assignment")
                {
                    break;
                }

                string[] token = command.Split(new String[] { "->" }, StringSplitOptions.None);

                if (teamsToListClass.Any(x => x.Members.Contains(token[0]))
                    || teamsToListClass.Any(x => x.User == token[0]))
                {
                    Console.WriteLine($"Member {token[0]} cannot join team {token[1]}!");
                }
                else if (!teamsToListClass.Any(x => x.TeamName == token[1]))
                {
                    Console.WriteLine($"Team {token[1]} does not exist!");
                }
                else
                {
                    var currTeam = teamsToListClass.Find(x => x.TeamName == token[1]);
                    currTeam.Members.Add(token[0]); //
                }
            }
            var fullTeam = teamsToListClass.Where(x => x.Members.Count > 0);
            var disband = teamsToListClass.Where(x => x.Members.Count == 0);

            foreach (var team in fullTeam.OrderByDescending(x => x.Members.Count).ThenBy(y => y.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.User}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in disband.OrderBy(x => x.TeamName))
            {
                Console.WriteLine($"{item.TeamName}");
            }
        }
    }
    class Team
    {
        public string User { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public Team(string user, string teamName)
        {
            this.User = user;
            this.TeamName = teamName;
        }
    }
}
