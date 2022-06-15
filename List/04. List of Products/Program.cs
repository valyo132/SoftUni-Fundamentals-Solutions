using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = new List<string>();

            int orders = int.Parse(Console.ReadLine());
            for (int i = 0; i < orders; i++)
            {
                string product = Console.ReadLine();
                shopping.Add(product);
            }
            shopping.Sort();
            for (int i = 1; i <= shopping.Count; i++)
            {
                Console.WriteLine($"{i}.{shopping[i - 1]}");
            }
        }
    }
}
