using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            while (true)
            {
                string[] command = Console.ReadLine().Split(">>>");
                if (command[0] == "Generate")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Contains":
                        Contains(rawActivationKey, command);
                        break;
                    case "Flip":
                        rawActivationKey = Flip(rawActivationKey, command);
                        break;
                    case "Slice":
                        rawActivationKey = Slice(rawActivationKey, command);
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }

        private static string Slice(string rawActivationKey, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);

            rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);

            Console.WriteLine(rawActivationKey);

            return rawActivationKey;
        }

        private static string Flip(string rawActivationKey, string[] command)
        {
            string move = command[1];
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);

            string substring = rawActivationKey.Substring(startIndex, endIndex - startIndex);

            if (move == "Upper")
            {
                rawActivationKey = rawActivationKey.Replace(substring, substring.ToUpper());
            }
            else
            {
                rawActivationKey = rawActivationKey.Replace(substring, substring.ToLower());
            }

            Console.WriteLine(rawActivationKey);

            return rawActivationKey;
        }

        private static void Contains(string rawActivationKey, string[] command)
        {
            string substring = command[1];

            if (rawActivationKey.Contains(substring))
            {
                Console.WriteLine($"{rawActivationKey} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
    }
}
