using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();
            int index = 0;

            List<char> letters = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                i = 0;

                index = input.IndexOf(input[i]);

                while (input[index + 1] == input[i])
                {
                    input = input.Remove(i, 1);

                    if (input.Length == 1)
                    {
                        sb.Append(input[i]);
                        Console.WriteLine(sb.ToString());
                        return;
                    }
                }
                sb.Append(input[index]);
                input = input.Remove(i, 1);
            }

            sb.Append(input[index]);
            Console.WriteLine(sb.ToString());
        }
    }
}
