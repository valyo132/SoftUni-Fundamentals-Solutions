using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombAndItspower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bombNumber = bombAndItspower[0];
            int powerNumber = bombAndItspower[1];

            while (numbers.Contains(bombNumber))
            {
                int bombIndex = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == bombNumber)
                    {
                        bombIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < powerNumber; i++)
                {
                    if (bombIndex - 1 >= 0)
                    {
                        numbers.RemoveAt(bombIndex - 1);
                        bombIndex--;
                    }
                }
                for (int i = 0; i < powerNumber; i++)
                {
                    if (bombIndex + 1 < numbers.Count)
                    {
                        numbers.RemoveAt(bombIndex + 1);
                    }
                }
                numbers.RemoveAt(bombIndex);
            }

            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
