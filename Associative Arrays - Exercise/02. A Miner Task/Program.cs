using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> resoursesAndQuality = new Dictionary<string, int>();

            while (true)
            {
                string resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }
                int quality = int.Parse(Console.ReadLine());

                if (!resoursesAndQuality.ContainsKey(resourse))
                {
                    resoursesAndQuality.Add(resourse, quality);
                }
                else
                {
                    resoursesAndQuality[resourse] += quality;
                }
            }

            foreach (var reasourse in resoursesAndQuality)
            {
                Console.WriteLine($"{reasourse.Key} -> {reasourse.Value}");
            }
        }
    }
}
