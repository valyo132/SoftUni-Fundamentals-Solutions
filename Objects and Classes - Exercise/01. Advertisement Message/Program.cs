using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product."
                    , "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!"
                    , "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            var randNumber = new Random();

            for (int i = 0; i < numberCount; i++)
            {
                string phrase = phrases[randNumber.Next(phrases.Length)];
                string eveent = events[randNumber.Next(events.Length)];
                string author = authors[randNumber.Next(authors.Length)];
                string city = cities[randNumber.Next(cities.Length)];

                Console.WriteLine($"{phrase} {eveent} {author} – {city}.");
            }
        }
    }
}
