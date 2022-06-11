using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharactersInRange(firstChar, secondChar);
        }

        static void CharactersInRange(char firstChar, char secondChar)
        {
            if (firstChar < secondChar)
            {
                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    char ch = (char)i;
                    Console.Write(ch + " ");
                }
            }
            else
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    char ch = (char)i;
                    Console.Write(ch + " ");
                }
            }
        }
    }
}
