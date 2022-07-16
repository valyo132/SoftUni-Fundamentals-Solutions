using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Console.WriteLine(SumOfWords(words));
        }

        private static int SumOfWords(string[] words)
        {
            string largerWord = "";
            string smallerWord = "";

            int result = 0;

            if (words[0].Length > words[1].Length)
            {
                largerWord = words[0];
                smallerWord = words[1];
            }
            else
            {
                largerWord = words[1];
                smallerWord = words[0];
            }

            int counter = 0;
            int limit = smallerWord.Length;

            for (int i = 0; counter < limit; i++, counter++)
            {
                result += largerWord[i] * smallerWord[i];

                largerWord = largerWord.Remove(0, 1);
                smallerWord = smallerWord.Remove(0, 1);

                i = -1;
            }

            for (int i = 0; i < largerWord.Length; i++)
            {
                result += largerWord[i];
            }

            return result;
        }
    }
}
