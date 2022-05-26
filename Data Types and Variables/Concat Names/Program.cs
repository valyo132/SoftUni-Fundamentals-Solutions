using System;

namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{name1}{delimiter}{name2}");
        }
    }
}
