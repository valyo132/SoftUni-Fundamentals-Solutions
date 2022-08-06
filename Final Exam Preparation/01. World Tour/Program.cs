using System;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allStops = Console.ReadLine();

            while (true)
            {
                string[] command = Console.ReadLine().Split(':');
                if (command[0] == "Travel")
                {
                    break;
                }
                string action = command[0];

                switch (action)
                {
                    case "Add Stop":
                        allStops = AddStop(allStops, command);
                        break;
                    case "Remove Stop":
                        allStops = RemoveStop(allStops, command);
                        break;
                    case "Switch":
                        allStops = SwitchStops(allStops, command);
                        break;

                }
                Console.WriteLine(allStops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {allStops}");
        }

        private static string SwitchStops(string allStops, string[] command)
        {
            string substring = command[1];
            string replacment = command[2];

            if (allStops.Contains(substring))
            {
                allStops = allStops.Replace(substring, replacment);
            }

            return allStops;
        }

        private static string RemoveStop(string allStops, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);

            if (startIndex >= 0 && startIndex < allStops.Length && endIndex >= 0 && endIndex < allStops.Length)
            {
                allStops = allStops.Remove(startIndex, endIndex - startIndex + 1);
            }

            return allStops;
        }

        private static string AddStop(string allStops, string[] command)
        {
            int index = int.Parse(command[1]);

            if (index >= 0 && index < allStops.Length)
            {
                string newStop = command[2];

                allStops = allStops.Insert(index, newStop);
            }

            return allStops;
        }
    }
}
