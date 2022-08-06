using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> allCities = new List<City>();

            while (true)
            {
                string[] command = Console.ReadLine().Split("||");
                if (command[0] == "Sail")
                {
                    break;
                }

                string cityName = command[0];
                int population = int.Parse(command[1]);
                int gold = int.Parse(command[2]);

                if (allCities.Any(x => x.Name == cityName))
                {
                    City wantedCity = allCities.Find(x => x.Name == cityName);

                    wantedCity.Population += population;
                    wantedCity.Gold += gold;
                }
                else
                {
                    City newCity = new City(cityName, population, gold);
                    allCities.Add(newCity);
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split("=>");
                if (command[0] == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Plunder":
                        Plunder(allCities, command);
                        break;
                    case "Prosper":
                        Prosper(allCities, command);
                        break;
                }
            }

            if (allCities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {allCities.Count} wealthy settlements to go to:");

                foreach (var city in allCities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        private static void Prosper(List<City> allCities, string[] command)
        {
            string prosperedCity = command[1];
            int amount = int.Parse(command[2]);

            if (amount >= 0)
            {
                City city = allCities.Find(x => x.Name == prosperedCity);
                city.Gold += amount;

                Console.WriteLine($"{amount} gold added to the city treasury. {city.Name} now has {city.Gold} gold.");
            }
            else
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }
        }

        private static void Plunder(List<City> allCities, string[] command)
        {
            string attackedCity = command[1];
            int killedPeople = int.Parse(command[2]);
            int stolenGold = int.Parse(command[3]);

            City city = allCities.Find(x => x.Name == attackedCity);
            city.Population -= killedPeople;
            city.Gold -= stolenGold;

            Console.WriteLine($"{city.Name} plundered! {stolenGold} gold stolen, {killedPeople} citizens killed.");

            if (city.Population <= 0 || city.Gold <= 0)
            {
                Console.WriteLine($"{city.Name} has been wiped off the map!");
                allCities.Remove(city);
            }
        }

        class City
        {
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }

            public City(string name, int population, int gold)
            {
                Name = name;
                Population = population;
                Gold = gold;
            }
        }
    }
}
