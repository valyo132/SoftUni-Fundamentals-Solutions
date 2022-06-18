using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sumOfRemovedElements = 0;
            int valueOfRemovedIndex = 0;

            while (sequenceList.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int lastIndex = sequenceList.Count - 1;

                if (index < 0)
                {
                    valueOfRemovedIndex = sequenceList[0];
                    sequenceList.RemoveAt(0);
                    sumOfRemovedElements += valueOfRemovedIndex;
                }
                else if (index > lastIndex)
                {
                    valueOfRemovedIndex = sequenceList[sequenceList.Count - 1];
                    sequenceList.RemoveAt(sequenceList.Count - 1);
                    sumOfRemovedElements += valueOfRemovedIndex;
                }
                else
                {
                    valueOfRemovedIndex = sequenceList[index];
                    sequenceList.RemoveAt(index);
                    sumOfRemovedElements += valueOfRemovedIndex;
                }

                for (int i = 0; i < sequenceList.Count; i++)
                {
                    if (sequenceList[i] <= valueOfRemovedIndex)
                    {
                        sequenceList[i] += valueOfRemovedIndex;
                    }
                    else
                    {
                        sequenceList[i] -= valueOfRemovedIndex;
                    }
                }

                if (index < 0)
                {
                    int copy = sequenceList[sequenceList.Count - 1];
                    sequenceList.Insert(0, copy);
                }
                else if (index > lastIndex)
                {
                    int copy = sequenceList[0];
                    sequenceList.Insert(sequenceList.Count, copy);
                }
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
