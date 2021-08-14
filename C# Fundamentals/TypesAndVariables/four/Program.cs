using System;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                char c = input[0];

                totalSum += (int)c;
            }
            
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
