using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 30/100

            Dictionary<string, int> treasure = new Dictionary<string, int>();
            treasure.Add("shards", 0);
            treasure.Add("motes", 0);
            treasure.Add("fragments", 0);

            bool flag = false;

            while (flag == false)
            {
                string[] line = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < line.Length - 1; i += 2)
                {
                    string currItem = line[i + 1];
                    int curritemQuality = int.Parse(line[i]);

                    if (!treasure.ContainsKey(currItem))
                    {
                        treasure.Add(currItem, curritemQuality);
                    }
                    else
                    {
                        treasure[currItem] += curritemQuality;
                    }

                    if (treasure["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        treasure["shards"] -= 250;
                        flag = true;
                        break;
                    }
                    else if (treasure["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        treasure["motes"] -= 250;
                        flag = true;
                        break;
                    }
                    else if (treasure["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        treasure["fragments"] -= 250;
                        flag = true;
                        break;
                    }
                }
            }

            var keyMaterials = treasure.Where(x => x.Key == "shards" || x.Key == "motes" || x.Key == "fragments" && x.Value > 0)
                .OrderBy(y => y.Value);
            var junk = treasure.Where(x => x.Key != "shards" && x.Key != "motes" && x.Key != "fragments" && x.Value > 0);

            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
