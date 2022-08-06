using System;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessege = Console.ReadLine();

            while (true)
            {
                string[] command = Console.ReadLine().Split('|');
                if (command[0] == "Decode")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Move":
                        encryptedMessege = MoveNumberOfLetters(encryptedMessege, command);
                        break;
                    case "Insert":
                        encryptedMessege = InsertValue(encryptedMessege, command);
                        break;
                    case "ChangeAll":
                        encryptedMessege = ChangeAllLetters(encryptedMessege, command);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessege}");
        }

        private static string ChangeAllLetters(string encryptedMessege, string[] command)
        {
            string substring = command[1];
            string replacment = command[2];

            return encryptedMessege = encryptedMessege.Replace(substring, replacment);
        }

        private static string InsertValue(string encryptedMessege, string[] command)
        {
            int index = int.Parse(command[1]);
            string valueToInsert = command[2];

            return encryptedMessege = encryptedMessege.Insert(index, valueToInsert);
        }

        private static string MoveNumberOfLetters(string encryptedMessege, string[] command)
        {
            int numberOfLetters = int.Parse(command[1]);

            string removedLetters = encryptedMessege.Substring(0, numberOfLetters);

            encryptedMessege = encryptedMessege.Remove(0, numberOfLetters);

            return encryptedMessege += removedLetters;
        }
    }
}
