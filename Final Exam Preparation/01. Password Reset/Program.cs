using System;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Done")
                {
                    break;
                }

                switch (command[0])
                {
                    case "TakeOdd":
                        input = TakeOdd(input);
                        break;
                    case "Cut":
                        input = Cut(input, command);
                        break;
                    case "Substitute":
                        input = Substitute(input, command);
                        break;

                }
            }

            Console.WriteLine($"Your password is: {input}");
        }

        private static string Substitute(string input, string[] command)
        {
            string substring = command[1];
            string substitute = command[2];

            if (input.Contains(substring))
            {
                input = input.Replace(substring, substitute);

                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            return input;
        }

        private static string Cut(string input, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int length = int.Parse(command[2]);

            string substring = input.Substring(startIndex, length);
            int index = input.IndexOf(substring);
            input = input.Remove(index, substring.Length);

            Console.WriteLine(input);
            return input;
        }

        private static string TakeOdd(string input)
        {
            string newRawPassword = "";

            for (int i = 1; i < input.Length; i += 2)
            {
                newRawPassword += input[i];
            }
            Console.WriteLine(newRawPassword);

            input = newRawPassword;
            return input;
        }
    }
}
