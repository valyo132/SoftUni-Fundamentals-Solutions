using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            switch (command)
            {
                case "int":
                    DataTypeInt();
                    break;
                case "real":
                    DataTypeDouble();
                    break;
                case "string":
                    DataTypeString();
                    break;
            }

            static void DataTypeInt()
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number * 2);
            }
            static void DataTypeDouble()
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{number * 1.5:f2}");
            }
            static void DataTypeString()
            {
                string word = Console.ReadLine();
                Console.WriteLine($"${word}$");
            }
        }
    }
}
