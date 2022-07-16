using System;
using System.Linq;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();

            int strenght = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strenght += int.Parse(input[i + 1].ToString());
                    sb.Append('>');
                }
                else if (strenght == 0)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    strenght--;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
