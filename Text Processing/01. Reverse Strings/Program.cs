using System;
using System.Text;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string reversedString = "";

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversedString += command[i];
                }

                Console.WriteLine($"{command} = {reversedString}");
            }
        }
    }
}
