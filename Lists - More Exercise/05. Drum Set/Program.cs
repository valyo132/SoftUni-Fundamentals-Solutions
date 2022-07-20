using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saving = double.Parse(Console.ReadLine());
            List<int> qualityOfEaxhDrumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> copy = qualityOfEaxhDrumSet.ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Hit it again, Gabsy!")
                {
                    break;
                }
                int power = int.Parse(command);

                for (int i = 0; i < qualityOfEaxhDrumSet.Count; i++)
                {
                    qualityOfEaxhDrumSet[i] -= power;

                    if (qualityOfEaxhDrumSet[i] <= 0)
                    {
                        int index = i;
                        int price = copy[index] * 3;
                        if (saving - price >= 0)
                        {
                            saving -= price;
                            qualityOfEaxhDrumSet[i] = copy[i];
                        }
                        else
                        {
                            qualityOfEaxhDrumSet.RemoveAt(i);
                            copy.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", qualityOfEaxhDrumSet));

            Console.WriteLine($"Gabsy has {saving:f2}lv.");
        }
    }
}
