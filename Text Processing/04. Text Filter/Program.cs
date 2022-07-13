using System;
using System.Linq;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                string asteriks = new string('*', word.Length);

                text = text.Replace(word, asteriks);
            }

            Console.WriteLine(text);
        }
    }
}
