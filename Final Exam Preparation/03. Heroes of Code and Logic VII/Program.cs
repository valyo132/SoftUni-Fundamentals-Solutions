using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfHeroes = int.Parse(Console.ReadLine());

            var allHeores = new List<Hero>();

            for (int i = 0; i < countOfHeroes; i++)
            {
                string[] hero = Console.ReadLine().Split();
                string name = hero[0];
                int HP = int.Parse(hero[1]);
                int MP = int.Parse(hero[2]);

                if (MP <= 200 && HP <= 100)
                {
                    Hero newHero = new Hero(name, HP, MP);
                    allHeores.Add(newHero);
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" - ");
                if (input[0] == "End")
                {
                    break;
                }

                switch (input[0])
                {
                    case "CastSpell":
                        CastSpell(allHeores, input);
                        break;

                    case "TakeDamage":
                        TakeDamage(allHeores, input);
                        break;

                    case "Recharge":
                        Recharge(allHeores, input);
                        break;

                    case "Heal":
                        Heal(allHeores, input);
                        break;
                }
            }

            foreach (var hero in allHeores)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HP}");
                Console.WriteLine($"  MP: {hero.MP}");
            }
        }

        private static void Heal(List<Hero> allHeores, string[] input)
        {
            string heroName = input[1];
            int amount = int.Parse(input[2]);

            Hero wantedHero = allHeores.Find(x => x.Name == heroName);

            if (wantedHero.HP + amount > 100)
            {
                amount = 100 - wantedHero.HP;
                wantedHero.HP = 100;
            }
            else
            {
                wantedHero.HP += amount;
            }

            Console.WriteLine($"{wantedHero.Name} healed for {amount} HP!");
        }

        private static void Recharge(List<Hero> allHeores, string[] input)
        {
            string heroName = input[1];
            int amount = int.Parse(input[2]);

            Hero wantedHero = allHeores.Find(x => x.Name == heroName);

            if (wantedHero.MP + amount > 200)
            {
                amount = 200 - wantedHero.MP;
                wantedHero.MP = 200;
            }
            else
            {
                wantedHero.MP += amount;
            }

            Console.WriteLine($"{wantedHero.Name} recharged for {amount} MP!");
        }

        private static void TakeDamage(List<Hero> allHeores, string[] input)
        {
            string heroName = input[1];
            int damage = int.Parse(input[2]);
            string attacker = input[3];

            Hero attackedHero = allHeores.Find(x => x.Name == heroName);

            attackedHero.HP -= damage;
            if (attackedHero.HP > 0)
            {
                Console.WriteLine($"{attackedHero.Name} was hit for {damage} HP by {attacker} and now has {attackedHero.HP} HP left!");
            }
            else
            {
                allHeores.Remove(attackedHero);

                Console.WriteLine($"{attackedHero.Name} has been killed by {attacker}!");
            }
        }

        private static void CastSpell(List<Hero> allHeores, string[] input)
        {
            string heroName = input[1];
            int MPneeded = int.Parse(input[2]);
            string spellName = input[3];

            Hero wantedHero = allHeores.Find(x => x.Name == heroName);
            if (wantedHero.MP >= MPneeded)
            {
                wantedHero.MP -= MPneeded;
                Console.WriteLine($"{wantedHero.Name} has successfully cast {spellName} and now has {wantedHero.MP} MP!");
            }
            else
            {
                Console.WriteLine($"{wantedHero.Name} does not have enough MP to cast {spellName}!");
            }
        }

        class Hero
        {
            public string Name { get; set; }
            public int HP { get; set; }
            public int MP { get; set; }

            public Hero(string name, int hP, int mP)
            {
                Name = name;
                HP = hP;
                MP = mP;
            }
        }
    }
}
