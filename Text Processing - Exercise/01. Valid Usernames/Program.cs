using System;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder validUsernames = new StringBuilder();

            string[] words = Console.ReadLine().ToLower().Split(", ");

            foreach (var word in words)
            {
                if (word.Length >= 3 && word.Length <= 16)
                {
                    if (IsUsernameValid(word))
                    {
                        validUsernames.AppendLine(word);
                    }
                }
            }

            Console.WriteLine(validUsernames.ToString());
        }

        private static bool IsUsernameValid(string word)
        {
            foreach (var ch in word)
            {
                if (char.IsLetterOrDigit(ch) || ch == '_' || ch == '-')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
