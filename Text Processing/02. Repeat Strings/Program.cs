using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                for (int k = 0; k < word.Length; k++)
                {
                    Console.Write(word);
                }
            }
        }
    }
}
