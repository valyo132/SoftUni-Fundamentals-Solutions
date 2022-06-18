using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shceduleLessons = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "course start")
                {
                    break;
                }
                string[] token = command.Split(':');

                switch (token[0])
                {
                    case "Add":
                        AddToList(shceduleLessons, token);
                        break;
                    case "Insert":
                        InsertToList(shceduleLessons, token);
                        break;
                    case "Remove":
                        RemoveFromList(shceduleLessons, token);
                        break;
                    case "Swap":
                        SwapLessonsInList(shceduleLessons, token);
                        break;
                    case "Exercise":
                        ExerciseAtList(shceduleLessons, token);
                        break;
                }
            }
            for (int i = 0; i < shceduleLessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{shceduleLessons[i]}");
            }
        }

        private static void ExerciseAtList(List<string> shceduleLessons, string[] token)
        {
            string lessonType = token[1];
            if (shceduleLessons.Contains(lessonType))
            {
                if (!shceduleLessons.Contains($"{lessonType}-Exercise"))
                {
                    int lessonIndex = shceduleLessons.IndexOf(lessonType);
                    string exercise = $"{lessonType}-Exercise";
                    shceduleLessons.Insert(lessonIndex + 1, exercise);
                }
            }
            else
            {
                shceduleLessons.Add(lessonType);
                shceduleLessons.Add($"{lessonType}-Exercise");
            }
        }

        private static void SwapLessonsInList(List<string> shceduleLessons, string[] token)
        {
            string firstLissonTitle = token[1];
            string secondLissonTitle = token[2];
            if (shceduleLessons.Contains(firstLissonTitle) && shceduleLessons.Contains(secondLissonTitle))
            {
                int first = shceduleLessons.IndexOf(firstLissonTitle);
                int second = shceduleLessons.IndexOf(secondLissonTitle);
                shceduleLessons.RemoveAt(first);
                shceduleLessons.Insert(first, secondLissonTitle);
                shceduleLessons.RemoveAt(second);
                shceduleLessons.Insert(second, firstLissonTitle);
                if (shceduleLessons.Contains($"{firstLissonTitle}-Exercise"))
                {
                    int index = shceduleLessons.IndexOf($"{firstLissonTitle}-Exercise");
                    shceduleLessons.RemoveAt(index);
                    shceduleLessons.Insert(second + 1, $"{firstLissonTitle}-Exercise");
                }
                if (shceduleLessons.Contains($"{secondLissonTitle}-Exercise"))
                {
                    int index = shceduleLessons.IndexOf($"{secondLissonTitle}-Exercise");
                    shceduleLessons.RemoveAt(index);
                    shceduleLessons.Insert(first + 1, $"{secondLissonTitle}-Exercise");
                }
            }
        }

        private static void RemoveFromList(List<string> shceduleLessons, string[] token)
        {
            string lessonToRemvoe = token[1];
            if (shceduleLessons.Contains(lessonToRemvoe))
            {
                shceduleLessons.Remove(lessonToRemvoe);
            }
        }

        private static void InsertToList(List<string> shceduleLessons, string[] token)
        {
            string lessonToAdd = token[1];
            int index = int.Parse(token[2]);
            if (!shceduleLessons.Contains(lessonToAdd))
            {
                shceduleLessons.Insert(index, lessonToAdd);
            }
        }

        private static void AddToList(List<string> shceduleLessons, string[] token)
        {
            string lessonToAdd = token[1];
            if (!shceduleLessons.Contains(lessonToAdd))
            {
                shceduleLessons.Add(lessonToAdd);
            }
        }
    }
}
