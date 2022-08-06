using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> register = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                string name = input[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = input[2];
                        RegisterCar(name, licensePlateNumber, register);
                        break;
                    case "unregister":
                        UnregisterCar(name, register);
                        break;
                }
            }

            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        private static void UnregisterCar(string name, Dictionary<string, string> register)
        {
            if (register.ContainsKey(name))
            {
                register.Remove(name);
                Console.WriteLine($"{name} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {name} not found");
            }
        }

        private static void RegisterCar(string name, string licensePlateNumber, Dictionary<string, string> register)
        {
            if (!register.ContainsKey(name))
            {
                register.Add(name, licensePlateNumber);
                Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            }
        }
    }
}
