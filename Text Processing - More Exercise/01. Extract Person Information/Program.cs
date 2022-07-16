using System;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfInput; i++)
            {
                string input = Console.ReadLine();

                int nameStartIndex = input.IndexOf('@') + 1;
                int nameEndIndex = input.IndexOf('|');
                string name = input.Substring(nameStartIndex, nameEndIndex - nameStartIndex);

                int ageStartIndex = input.IndexOf('#') + 1;
                int ageEndIndex = input.IndexOf('*');
                string age = input.Substring(ageStartIndex, ageEndIndex - ageStartIndex);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
