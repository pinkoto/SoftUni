using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bombData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombData[0];
            int power = bombData[1];

            while (true)
            {
                int idx = numbers.IndexOf(bombNumber);

                if (idx == -1)
                {
                    break;
                }

                int startIdx = idx - power;

                if (startIdx < 0)
                {
                    startIdx = 0;
                }

                int elementsToBlow = 2 * power + 1;

                if (elementsToBlow > numbers.Count - startIdx)
                {
                    elementsToBlow = numbers.Count - startIdx;
                }

                numbers.RemoveRange(startIdx, elementsToBlow);

            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
