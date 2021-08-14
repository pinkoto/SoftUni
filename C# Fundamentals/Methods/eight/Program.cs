using System;

namespace eight
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double firstFactoriel = CalculateFactriel(first);
            double secondFactoriel = CalculateFactriel(second);

            Console.WriteLine($"{firstFactoriel / secondFactoriel:f2}");
        }

        private static double CalculateFactriel(int number)
        {
            double total = 1;
            for (int i = 2; i <= number; i++)
            {
                total *= i;
            }

            return total;
        }
    }
}
