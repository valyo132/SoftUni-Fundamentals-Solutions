using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"[ ](?<email>[A-Za-z0-9]+[-_\.]?[A-Za-z0-9]+@[A-Za-z]+[-._]?[A-Za-z]+?\.[A-Za-z]+\.?[A-Za-z]+)";

            MatchCollection emails = Regex.Matches(input, pattern);
            foreach (Match match in emails)
            {
                Console.WriteLine(match.Groups["email"].Value);
            }
        }
    }
}
