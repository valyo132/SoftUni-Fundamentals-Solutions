using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalMoneySpend = 0;

            Console.WriteLine("Bought furniture:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }

                string pattern = @">>(?<item>[A-Z]+[a-z]*)<<(?<price>[0-9]+[.[0-9]+]*)!(?<quantity>[0-9]+)";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    totalMoneySpend += double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value);

                    Console.WriteLine(match.Groups["item"]);
                }
            }

            Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");
        }
    }
}
