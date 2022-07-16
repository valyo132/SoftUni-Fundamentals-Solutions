using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string messege = Console.ReadLine();

            for (int i = 0; i < messege.Length; i++)
            {
                char ch = messege[i];
                sb.Append((char)(ch + 3));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
