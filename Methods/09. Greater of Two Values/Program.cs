using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            switch (command)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(firstNumber, secondNumber));
                    break;

                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();

                    Console.WriteLine(GetMax(firstString, secondString));
                    break;

                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(firstChar,secondChar));
                    break;
            }
        }
        static int GetMax(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }

        static string GetMax(string firstString, string secondString)
        {
            int result = firstString.CompareTo(secondString);
            return result > 0 ? firstString : secondString;
        }

        static char GetMax(char firstChar, char secondChar)
        {
            return firstChar > secondChar ? firstChar : secondChar;
        }
    }
}
