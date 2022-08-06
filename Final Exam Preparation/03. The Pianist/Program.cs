using System;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, string> pieceAndComposer = new Dictionary<string, string>();
            Dictionary<string, string> pieceAndKey = new Dictionary<string, string>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] inputPiece = Console.ReadLine().Split("|");
                string currPiece = inputPiece[0];
                string currComposer = inputPiece[1];
                string currKey = inputPiece[2];

                pieceAndComposer.Add(currPiece, currComposer);
                pieceAndKey.Add(currPiece, currKey);
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split('|');
                if (commands[0] == "Stop")
                {
                    break;
                }

                switch (commands[0])
                {
                    case "Add":
                        AddPiceToCollection(pieceAndComposer, pieceAndKey, commands);
                        break;
                    case "Remove":
                        RemovePiece(pieceAndComposer, pieceAndKey, commands);
                        break;
                    case "ChangeKey":
                        ChangePieceKey(pieceAndKey, commands);
                        break;
                }
            }

            foreach (var piece in pieceAndComposer)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {pieceAndKey[piece.Key]}");
            }
        }

        private static void ChangePieceKey(Dictionary<string, string> pieceAndKey, string[] commands)
        {
            if (pieceAndKey.ContainsKey(commands[1]))
            {
                pieceAndKey[commands[1]] = commands[2];

                Console.WriteLine($"Changed the key of {commands[1]} to {commands[2]}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {commands[1]} does not exist in the collection.");
            }
        }

        private static void RemovePiece(Dictionary<string, string> pieceAndComposer, Dictionary<string, string> pieceAndKey, string[] commands)
        {
            if (pieceAndComposer.ContainsKey(commands[1]))
            {
                pieceAndComposer.Remove(commands[1]);
                pieceAndKey.Remove(commands[1]);

                Console.WriteLine($"Successfully removed {commands[1]}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {commands[1]} does not exist in the collection.");
            }
        }

        private static void AddPiceToCollection(Dictionary<string, string> pieceAndComposer, Dictionary<string, string> pieceAndKey, string[] commands)
        {
            if (!pieceAndComposer.ContainsKey(commands[1]))
            {
                pieceAndComposer.Add(commands[1], commands[2]);
                pieceAndKey.Add(commands[1], commands[3]);

                Console.WriteLine($"{commands[1]} by {commands[2]} in {commands[3]} added to the collection!");
            }
            else
            {
                Console.WriteLine($"{commands[1]} is already in the collection!");
            }
        }
    }
}
