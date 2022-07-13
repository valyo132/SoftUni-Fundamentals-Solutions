using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            while (secondString.Contains(firstString))
            {
                int index = secondString.IndexOf(firstString);

                secondString = secondString.Remove(index, firstString.Length);
            }

            Console.WriteLine(secondString);
        }
    }
}
