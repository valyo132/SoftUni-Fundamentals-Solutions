using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string splitPattern = @"[,\s]+";
            //string jackpotPattern = @"[@#$^]{20}";
            //string winningHalf = @"[@#$^]{6,9}";
            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            string[] tickets = Regex.Split(input, splitPattern).ToArray();

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length == 20)
                {
                    var leftHalf = regex.Match(tickets[i].Substring(0, 10));
                    var rigthHalf = regex.Match(tickets[i].Substring(10));
                    int minLength = Math.Min(leftHalf.Length, rigthHalf.Length);

                    if (leftHalf.Success && rigthHalf.Success)
                    {
                        string winLeftHalf = leftHalf.Value.Substring(0, minLength);
                        string winRigthHalf = rigthHalf.Value.Substring(0, minLength);

                        if (winLeftHalf == winRigthHalf)
                        {
                            if (winLeftHalf.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {minLength}{winLeftHalf.Substring(0, 1)} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {minLength}{winRigthHalf.Substring(0, 1)}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
