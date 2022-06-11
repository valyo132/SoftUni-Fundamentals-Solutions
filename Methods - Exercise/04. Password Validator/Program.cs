using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            PasswordValidator(password);
        }

        static void PasswordValidator(string password)
        {
            bool neededDigitsCount = false;
            bool passLength = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                passLength = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool special = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (!(password[i] >= 'a' && password[i] <= 'z'
                    || password[i] >= 'A' && password[i] <= 'Z'
                    || password[i] >= '0' && password[i] <= '9'))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    special = false;
                    break;
                }
            }

            int digitCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    digitCount++;
                }
            }
            if (digitCount >= 2)
            {
                neededDigitsCount = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (passLength && neededDigitsCount && special)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
