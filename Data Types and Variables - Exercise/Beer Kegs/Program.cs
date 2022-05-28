using System;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfKegs = int.Parse(Console.ReadLine());

            double max = 0;
            string biggestKeg = "";
            for (int i = 0; i < countOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heigth = int.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * (double)heigth;
                if (volume > max)
                {
                    max = volume;
                    biggestKeg = kegModel;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
