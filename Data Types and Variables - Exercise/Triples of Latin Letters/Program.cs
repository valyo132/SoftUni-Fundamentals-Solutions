using System;

namespace TriplesOfLatinLetters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + number; i++)
            {
                for (char k = 'a'; k < 'a' + number; k++)
                {
                    for (char l = 'a'; l < 'a' + number; l++)
                    {
                        Console.WriteLine($"{i}{k}{l}");
                    }
                }
            }
        }
    }
}
