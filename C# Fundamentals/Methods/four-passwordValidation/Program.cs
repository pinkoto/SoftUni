using System;

namespace four_passwordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isValid = true;

            if (input.Length<6||input.Length>10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (InvalidSymbols(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (NotEnoughDigits(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool NotEnoughDigits(string pWord)
        {
            int digitCount = 0;
            foreach (char symbol in pWord)
            {
                if (char.IsDigit(symbol))
                {
                    digitCount++;
                }

                if (digitCount>=2)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool InvalidSymbols(string pWord)
        {
            foreach (char symbol in pWord)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
