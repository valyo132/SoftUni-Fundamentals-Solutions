using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var morseAlphabetDictionary = new Dictionary<string, char>()
            {
                  {".-", 'a'}, {"-...", 'b'}, {"-.-.", 'c'}, {"-..", 'd'},  {".", 'e'},
                  {"..-.", 'f'}, {"--.", 'g'}, {"....", 'h'}, {"..", 'i'}, {".---", 'j'},
                  {"-.-", 'k'}, {".-..", 'l'},{ "--",'m'}, {"-.", 'n'},{"---", 'o'}, {".--.", 'p'},
                  {"--.-", 'q'},{".-.", 'r'}, {"...", 's'}, {"-", 't'}, {"..-", 'u'}, {"...-", 'v'},
                  {".--", 'w'}, {"-..-", 'x'}, {"-.--", 'y'},  {"--..", 'z'},
            };

            string[] input = Console.ReadLine().Split();

            string messege = "";

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                if (current == "|")
                {
                    messege += " ";
                    continue;
                }

                if (morseAlphabetDictionary.ContainsKey(current))
                {
                    messege += morseAlphabetDictionary[current];
                }
            }

            Console.WriteLine(messege.ToUpper());
        }
    }
}
