﻿using System;

namespace Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < countOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter;
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}
