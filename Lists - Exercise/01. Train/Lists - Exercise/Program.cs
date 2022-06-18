using System;
using System.Linq;
using System.Collections.Generic;

namespace Lists___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passangersPerWagon = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] token = input.Split();

                if (token.Length == 2)
                {
                    passangersPerWagon.Add(int.Parse(token[1]));
                }
                else
                {
                    bool flag = false;
                    for (int i = 0; i < passangersPerWagon.Count; i++)
                    {
                        int passengerToAddOnAWagon = int.Parse(token[0]);
                        if (passengerToAddOnAWagon + passangersPerWagon[i] <= maxCapacityOfWagon)
                        {
                            passangersPerWagon[i] += passengerToAddOnAWagon;
                            flag = true;
                        }
                        if (flag) { break; }
                    }
                }
            }
            Console.WriteLine(String.Join(' ', passangersPerWagon));
        }
    }
}
