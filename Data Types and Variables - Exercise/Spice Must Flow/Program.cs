using System;

namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());

            uint sum = 0;
            int days = 0;
            while (startingYield >= 100)
            {
                sum += startingYield - 26;
                startingYield -= 10;
                days++;
                if (startingYield < 100)
                {
                    sum -= 26;
                }
            }
            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
