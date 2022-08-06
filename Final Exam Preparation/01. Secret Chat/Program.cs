using System;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessege = Console.ReadLine();

            while (true)
            {
                string[] command = Console.ReadLine().Split(":|:");
                if (command[0] == "Reveal")
                {
                    break;
                }

                switch (command[0])
                {
                    case "InsertSpace":
                        concealedMessege = InsertSpace(concealedMessege, command);
                        break;
                    case "Reverse":
                        concealedMessege = Reverse(concealedMessege, command);
                        break;
                    case "ChangeAll":
                        concealedMessege = ChangeAll(concealedMessege, command);
                        break;
                }
            }

            Console.WriteLine($"You have a new text message: {concealedMessege}");
        }

        private static string ChangeAll(string concealedMessege, string[] command)
        {
            string substring = command[1];
            string replacemnet = command[2];

            concealedMessege = concealedMessege.Replace(substring, replacemnet);

            Console.WriteLine(concealedMessege);
            return concealedMessege;
        }

        private static string Reverse(string concealedMessege, string[] command)
        {
            string substring = command[1];

            if (concealedMessege.Contains(substring))
            {
                int startIndex = concealedMessege.IndexOf(substring);
                concealedMessege = concealedMessege.Remove(startIndex, substring.Length);

                for (int i = substring.Length - 1; i >= 0; i--)
                {
                    concealedMessege += substring[i];
                }

                Console.WriteLine(concealedMessege);
            }
            else
            {
                Console.WriteLine("error");
            }

            return concealedMessege;
        }

        private static string InsertSpace(string concealedMessege, string[] command)
        {
            int index = int.Parse(command[1]);
            concealedMessege = concealedMessege.Insert(index, " ");

            Console.WriteLine(concealedMessege);
            return concealedMessege;
        }
    }
}
