using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Plant> allPlants = new List<Plant>();

            int countOfinput = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfinput; i++)
            {
                string[] input = Console.ReadLine().Split("<->");

                string plant = input[0];
                int rarity = int.Parse(input[1]);

                if (allPlants.Any(x => x.Name == plant))
                {
                    Plant wantedPlant = allPlants.Find(x => x.Name == plant);
                    wantedPlant.Rarity = rarity;
                }
                else
                {
                    Plant newPlant = new Plant(plant, rarity);
                    allPlants.Add(newPlant);
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(": ");
                if (command[0] == "Exhibition")
                {
                    break;
                }

                string[] token = command[1].Split(" - ");

                switch (command[0])
                {
                    case "Rate":
                        Rate(allPlants, token);
                        break;
                    case "Update":
                        Update(allPlants, token);
                        break;
                    case "Reset":
                        Reset(allPlants, token);
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in allPlants)
            {
                double avarageRaiting = 0;

                if (plant.Raiting.Count > 0)
                {
                    avarageRaiting = plant.Raiting.Average();
                }
                else
                {
                    avarageRaiting = 0;
                }

                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {avarageRaiting:f2}");
            }
        }

        private static void Reset(List<Plant> allPlants, string[] token)
        {
            string plantToFind = token[0];

            if (allPlants.Any(x => x.Name == plantToFind))
            {
                Plant wantedPlant = allPlants.Find(x => x.Name == plantToFind);
                wantedPlant.Raiting.Clear();
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void Update(List<Plant> allPlants, string[] token)
        {
            string plantToFind = token[0];
            int newRarity = int.Parse(token[1]);

            if (allPlants.Any(x => x.Name == plantToFind))
            {
                Plant wantedPlant = allPlants.Find(x => x.Name == plantToFind);
                wantedPlant.Rarity = newRarity;
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void Rate(List<Plant> allPlants, string[] token)
        {
            string plantToFind = token[0];
            int raitingToAdd = int.Parse(token[1]);

            if (allPlants.Any(x => x.Name == plantToFind))
            {
                Plant wantedPlant = allPlants.Find(x => x.Name == plantToFind);
                wantedPlant.Raiting.Add(raitingToAdd);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        class Plant
        {

            public string Name { get; set; }
            public int Rarity { get; set; }
            public List<int> Raiting { get; set; }

            public Plant(string name, int rarity)
            {
                Name = name;
                Rarity = rarity;
                Raiting = new List<int>();
            }
        }
    }
}
