using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int countOfHands = firstPlayer.Count;

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                for (int i = 0; i < countOfHands; i++)
                {
                    int lastCard = 0, secondToLastCard = 0;
                    if (firstPlayer[i] > secondPlayer[i])
                    {
                        lastCard = secondPlayer[i];
                        secondToLastCard = firstPlayer[i];
                        firstPlayer.RemoveAt(i);
                        secondPlayer.RemoveAt(i);
                        firstPlayer.Add(secondToLastCard);
                        firstPlayer.Add(lastCard);
                        i = -1;
                        break;
                    }
                    else if (firstPlayer[i] < secondPlayer[i])
                    {
                        lastCard = firstPlayer[i];
                        secondToLastCard = secondPlayer[i];
                        secondPlayer.RemoveAt(i);
                        firstPlayer.RemoveAt(i);
                        secondPlayer.Add(secondToLastCard);
                        secondPlayer.Add(lastCard);
                        i = -1;
                        break;
                    }
                    else
                    {
                        firstPlayer.RemoveAt(i);
                        secondPlayer.RemoveAt(i);
                        i = -1;
                        break;
                    }
                }
            }
            int sum = 0;
            if (firstPlayer.Count > secondPlayer.Count)
            {
                foreach (var card in firstPlayer)
                {
                    sum += card;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                foreach (var card in secondPlayer)
                {
                    sum += card;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
