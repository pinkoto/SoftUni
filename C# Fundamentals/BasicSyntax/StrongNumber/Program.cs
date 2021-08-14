using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;
            int fsSum = 0;

            bool done = false;

            while (number > 0)
            {
                int lastDigit = number % 10;
                int factoriel = 1;
                for (int i = lastDigit; i >= 0; i--)
                {
                    factoriel *= i;
                }
                fsSum += factoriel;
                number /= 10;

            }
            if (fsSum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
