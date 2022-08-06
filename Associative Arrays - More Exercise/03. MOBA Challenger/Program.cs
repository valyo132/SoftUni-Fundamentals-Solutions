using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> allPlayers = new List<Player>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }

                if (!input.Contains("vs"))
                {
                    string[] token = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string playerName = token[0];
                    string possision = token[1];
                    int skill = int.Parse(token[2]);

                    if (!allPlayers.Any(x => x.Name == playerName))
                    {
                        var newPlayer = new Player(playerName);
                        allPlayers.Add(newPlayer);
                    }
                    
                    Player currPlayer = allPlayers.FirstOrDefault(x => x.Name == playerName);
                    if (currPlayer.PositionAndSkill.ContainsKey(possision))
                    {
                        if (currPlayer.PositionAndSkill[possision] < skill)
                        {
                            currPlayer.PositionAndSkill[possision] = skill;
                        }
                    }
                    else
                    {
                        currPlayer.PositionAndSkill.Add(possision, skill);
                    }
                }
                else
                {
                    string[] battle = input.Split(" vs ");

                    string playerOne = battle[0];
                    string playerTwo = battle[1];

                    if (allPlayers.Any(x => x.Name == playerOne) && allPlayers.Any(x => x.Name == playerTwo))
                    {
                        Player first = allPlayers.Find(x => x.Name == playerOne);
                        Player second = allPlayers.Find(x => x.Name == playerTwo);

                        foreach (var poss1 in first.PositionAndSkill.Keys)
                        {
                            foreach (var poss2 in second.PositionAndSkill.Keys)
                            {
                                if (poss1 == poss2)
                                {
                                    if (first.TotalPlayerPoints < second.TotalPlayerPoints)
                                    {
                                        allPlayers.Remove(first);
                                    }
                                    else if (first.TotalPlayerPoints > second.TotalPlayerPoints)
                                    {
                                        allPlayers.Remove(second);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (var player in allPlayers.OrderByDescending(x => x.TotalPlayerPoints).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{player.Name}: {player.TotalPlayerPoints} skill");
                foreach (var poss in player.PositionAndSkill.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"- {poss.Key} <::> {poss.Value}");
                }
            }
        }

        class Player
        {
            public string Name { get; set; }
            public Dictionary<string, int> PositionAndSkill { get; set; }
            public int TotalPlayerPoints { get { return PositionAndSkill.Values.Sum(); } }

            public Player(string name)
            {
                Name = name;
                PositionAndSkill = new Dictionary<string, int>();
            }
        }
    }
}
