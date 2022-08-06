using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());

            List<Dragon> allDragons = new List<Dragon>();

            for (int i = 0; i < countOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split();

                string color = input[0];
                string name = input[1];
                int damage = int.Parse(input[2]);
                int health = int.Parse(input[3]);
                int armor = int.Parse(input[4]);

                if (!allDragons.Any(x => x.Name == name))
                {
                    Dragon newDragon = new Dragon(name);
                    allDragons.Add(newDragon);
                }

                Dragon currDragon = allDragons.Find(x => x.Name == name);
                if (!currDragon.allDragons.)
                {

                }
            }
        }

        class Dragon
        {
            public string Color { get; set; }
            public string Name { get; set; }
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }

            public Dragon(string name)
            {
                Name = name;
                Damage = 45;
                Health = 250;
                Armor = 10;
            }
        }
    }
}
