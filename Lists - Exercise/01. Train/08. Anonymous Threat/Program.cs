using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "3:1")
                {
                    break;
                }
                string[] token = command.Split(' ');

                switch (token[0])
                {
                    case "merge":
                        MegreStrings(data, token);
                        break;
                    case "divide":
                        DivideStrings(data, token);
                        break;
                }
            }
            Console.WriteLine(String.Join(' ', data));
        }

        private static void DivideStrings(List<string> data, string[] token)
        {
            int indexToBeDivided = int.Parse(token[1]);
            int partitions = int.Parse(token[2]);

            var dividedList = new List<string>();
            int countPerPartition = data[indexToBeDivided].Length / partitions;

            string word = data[indexToBeDivided];
            data.Remove(word);
            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    dividedList.Add(word.Substring(i * countPerPartition));
                }
                else
                {
                    dividedList.Add(word.Substring(i * countPerPartition, countPerPartition));
                }
            }
            data.InsertRange(indexToBeDivided, dividedList);
        }

        private static void MegreStrings(List<string> data, string[] token)
        {
            int startIndex = int.Parse(token[1]);
            int endIndex = int.Parse(token[2]);
            if (endIndex > data.Count - 1 || endIndex < 0)
            {
                endIndex = data.Count - 1;
            }
            int countOfRepeats = endIndex - startIndex;

            if (startIndex < 0 || startIndex > data.Count - 1)
            {
                startIndex = 0;
            }

            string concatedWord = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                concatedWord += data[i];
            }
            data.RemoveRange(startIndex, endIndex - startIndex + 1);
            data.Insert(startIndex, concatedWord);
        }
    }
}
