using System;
using System.Collections.Generic;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                string listType = data[0];
                string name = data[1];
                string time = data[2];

                Song newSong = new Song(listType, name, time);

                songs.Add(newSong);
            }

            string wantedType = Console.ReadLine();

            if (wantedType == "all")
            {
                foreach (Song item in songs)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (Song item in songs)
                {
                    if (item.TypeList == wantedType)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    }
}
