using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = random.Next(words.Length);

                string currentWord = words[i];

                words[i] = words[index];
                words[index] = currentWord;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
