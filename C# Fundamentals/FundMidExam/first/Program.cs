using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            int buiscuitsPerDay = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int target = int.Parse(Console.ReadLine());

            int produce = 20 * (buiscuitsPerDay * workersCount) + 10 * (int)Math.Floor(buiscuitsPerDay * workersCount * 0.75);
            int difference = Math.Abs(produce - target);
            double diffPercentage = Math.Round((difference * 1.0 / target) * 100, 2);
            if (target < produce)
            {
                Console.WriteLine($"You have produced {produce} biscuits for the past month.");
                Console.WriteLine($"You produce {diffPercentage:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You have produced {produce} biscuits for the past month.");
                Console.WriteLine($"You produce {diffPercentage:f2} percent less biscuits.");
            }
        }
    }
}
