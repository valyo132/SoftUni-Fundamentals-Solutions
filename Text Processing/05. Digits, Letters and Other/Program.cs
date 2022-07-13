using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            string digits = "";
            string letters = "";
            string symbols = "";

            foreach (var ch in input)
            {
                if (Char.IsDigit(ch))
                {
                    digits += ch;
                }
                else if (Char.IsLetter(ch))
                {
                    letters += ch;
                }
                else
                {
                    symbols += ch;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
