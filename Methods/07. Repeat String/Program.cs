using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            Repeat(repeats, str);
        }
        static void Repeat(int repeats,string str)
        {
            for (int i = 0; i < repeats; i++)
            {
                Console.Write(str);
            }
        }
    }
}
