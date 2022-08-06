using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            string pattern = @"@[#]{1,}(?<barcode>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})@[#]{1,}";

            for (int i = 0; i < countOfInputs; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string barcode = match.Groups["barcode"].Value.ToString();

                    var digits = barcode.Where(x => char.IsDigit(x)).ToList();

                    string productGroup = "";
                    if (digits.Count == 0)
                    {
                        productGroup = "00";
                    }
                    else
                    {
                        foreach (var digit in digits)
                        {
                            productGroup += digit;
                        }
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
