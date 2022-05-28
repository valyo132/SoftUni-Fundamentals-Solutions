using System;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int startingPower = pokePower;
            int count = 0;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                count++;
                if (startingPower * 0.5 == pokePower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
