using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<count>[0-9]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";

            double totalIncome = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }

                if (Regex.IsMatch(input, pattern))
                {
                    string name = Regex.Match(input, pattern).Groups["name"].Value;
                    string product = Regex.Match(input, pattern).Groups["product"].Value;
                    int count = int.Parse(Regex.Match(input, pattern).Groups["count"].Value);
                    double price = double.Parse(Regex.Match(input, pattern).Groups["price"].Value);

                    double priceForCurrProduct = price * count;
                    Console.WriteLine($"{name}: {product} - {priceForCurrProduct:f2}");

                    totalIncome += priceForCurrProduct;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
