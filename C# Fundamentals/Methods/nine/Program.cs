using System;

namespace nine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    return;
                }

                if (IsPalindrome(input) == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        private static bool IsPalindrome(string input)
        {

                for (int i = 0; i < input.Length / 2; i++)
                {
                    char digit = input[i];
                    char backwardsDigit = input[input.Length - 1 - i];

                    if (digit!=backwardsDigit)
                    {
                        return false;
                    }
                }

            return true;
        }
    }
}
