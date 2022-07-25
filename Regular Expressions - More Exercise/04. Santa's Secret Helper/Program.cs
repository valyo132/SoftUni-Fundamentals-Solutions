using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]+!(?<behavior>[GN])!";

            var namesToPrint = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var messege = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    messege.Append((char)(input[i] - key));
                }

                Match match = Regex.Match(messege.ToString(), pattern);

                if (match.Groups["behavior"].Value == "G")
                {
                    Console.WriteLine($"{match.Groups["name"].Value}");
                }
            }
        }
    }
}
