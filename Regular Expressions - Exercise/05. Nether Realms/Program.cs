using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^\+\-\*\/\.,0-9]";
            string damagePattern = @"-?\d+\.?\d*";
            string multyplicationPattern = @"[\*\/]";
            string splitPattern = @"[,\s]+";

            string input = Console.ReadLine();
            string[] deamons = Regex.Split(input, splitPattern).OrderBy(x => x).ToArray();

            for (int k = 0; k < deamons.Length; k++)
            {
                double health = 0;
                MatchCollection matches = Regex.Matches(deamons[k], healthPattern);
                for (int i = 0; i < matches.Count; i++)
                {
                    health += char.Parse(matches[i].ToString());
                }

                double deamonsDamage = 0;
                MatchCollection damage = Regex.Matches(deamons[k], damagePattern);

                for (int i = 0; i < damage.Count; i++)
                {
                    deamonsDamage += double.Parse(damage[i].ToString());
                }

                MatchCollection multyplicationSymbols = Regex.Matches(deamons[k], multyplicationPattern);

                for (int i = 0; i < multyplicationSymbols.Count; i++)
                {
                    char currOperator = char.Parse(multyplicationSymbols[i].ToString());
                    if (currOperator == '*')
                    {
                        deamonsDamage *= 2;
                    }
                    else
                    {
                        deamonsDamage /= 2;
                    }
                }

                Console.WriteLine($"{deamons[k]} - {health} health, {deamonsDamage:f2} damage");
            }
        }
    }
}
