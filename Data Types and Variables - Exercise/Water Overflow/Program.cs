using System;

namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;

            int countRecieving = int.Parse(Console.ReadLine());

            int sumOfLiters = 0;
            for (int i = 0; i < countRecieving; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters + sumOfLiters <= capacity)
                {
                    sumOfLiters += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(sumOfLiters);
        }
    }
}
