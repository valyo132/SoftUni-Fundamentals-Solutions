using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<string> resultMesseges = new List<string>();

            string messege = "";

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "find")
                {
                    break;
                }
                messege = "";

                int count = 0;
                for (int i = 0; i < line.Length; i++)
                {
                    for (int k = count; k < key.Length; k++)
                    {
                        messege += (char)(line[i] - key[k]);
                        count++;
                        if (count == key.Length)
                        {
                            count = 0;
                        }
                        break;
                    }
                }

                int treasureTypeStart = messege.IndexOf('&') + 1;
                int treasureTypeEnd = messege.LastIndexOf('&');
                string type = messege.Substring(treasureTypeStart, treasureTypeEnd - treasureTypeStart);

                int startIndexOfCoordinates = messege.IndexOf('<') + 1;
                int endIndexOfCoordinates = messege.IndexOf('>');
                string coordinates = messege.Substring(startIndexOfCoordinates, endIndexOfCoordinates - startIndexOfCoordinates);

                resultMesseges.Add($"Found {type} at {coordinates}");
            }

            foreach (var sentence in resultMesseges)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
