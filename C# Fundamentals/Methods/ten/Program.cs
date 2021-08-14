using System;

namespace ten
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (ContainsOddDigit(i) && DivisibleByEight(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool DivisibleByEight(int number)
        {
            int digitSum = 0;

            while (number>0)
            {
                int lastDigit = number % 10;
                digitSum += lastDigit;
                number /= 10;
            }

            if (digitSum%8==0)
            {
                return true;
            }

            return false;
        }

        private static bool ContainsOddDigit(int n)
        {
            while (n>0)
            {
                int currentDigit = n % 10;
                if (!(currentDigit%2==0))
                {
                    return true;
                }

                n /= 10;
            }

            return false;
        }
    }
}
