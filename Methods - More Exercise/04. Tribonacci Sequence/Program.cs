using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine(1);
            }
            else if (number >= 2)
            {
                Tribonacci(number);
            }
        }
        static void Tribonacci(int number)
        {
            int n1 = 0, n2 = 1, n3 = 1;
            Console.Write(n2 + " " + n3 + " ");

            for (int i = 2; i < number; i++)
            {
                int nextNumber = n1 + n2 + n3;
                Console.Write(nextNumber + " ");
                n1 = n2;
                n2 = n3;
                n3 = nextNumber;
            }
        }
    }
}
