using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            string stringToWork = Console.ReadLine();

            int result = 0;

            for (int i = 0; i < stringToWork.Length; i++)
            {
                if (stringToWork[i] > firstSymbol && stringToWork[i] < secondSymbol)
                {
                    result += stringToWork[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
