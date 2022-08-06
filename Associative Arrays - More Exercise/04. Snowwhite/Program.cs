using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> allDwarfs = new List<Dwarf>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Once upon a time")
                {
                    break;
                }

                string name = input[0];
                string hatColor = input[1];
                int physics = int.Parse(input[2]);

                if (!allDwarfs.Any(x => x.Name == name))
                {
                    Dwarf newDwarf = new Dwarf(name, hatColor, physics);
                    allDwarfs.Add(newDwarf);
                }
                else
                {
                    if (allDwarfs.Any(x => x.Name == name && x.HatColor == hatColor))
                    {
                        Dwarf sameDwarf = allDwarfs.Find(x => x.Name == name && x.HatColor == hatColor);
                        if (sameDwarf.Physics < physics)
                        {
                            sameDwarf.Physics = physics;
                        }
                    }
                    else
                    {
                        Dwarf newDwarf = new Dwarf(name, hatColor, physics);
                        allDwarfs.Add(newDwarf);
                    }
                }
            }

            foreach (var dwarf in allDwarfs.OrderByDescending(dwarf => dwarf.Physics)
                .ThenByDescending(dwarf => allDwarfs.Where(listdwarf => listdwarf.HatColor == dwarf.HatColor).Count()))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        class Dwarf
        {
            public string Name { get; set; }
            public string HatColor { get; set; }
            public int Physics { get; set; }

            public Dwarf(string name, string hatColor, int physics)
            {
                Name = name;
                HatColor = hatColor;
                Physics = physics;
            }
        }
    }
}
