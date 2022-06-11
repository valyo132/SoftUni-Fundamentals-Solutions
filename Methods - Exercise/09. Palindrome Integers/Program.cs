using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome();
        }

        static void Palindrome()
        {
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                int number = int.Parse(input);

                string reversedString = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    char symbol = input[i];
                    reversedString += symbol;
                }
                if (reversedString == input)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
