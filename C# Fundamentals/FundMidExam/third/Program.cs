using System;
using System.Linq;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int entry = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine();
            int entryPrice = items[entry];

            int leftPrice = 0;
            int rightPrice = 0;

            for (int i = entry - 1; i >= 0; i--)
            {
                int current = items[i];
                if (itemType == "cheap")
                {
                    if (current < entryPrice)
                    {
                        leftPrice += current;
                    }
                }
                else
                {
                    if (current >= entryPrice)
                    {
                        leftPrice += current;
                    }
                }
            }

            for (int i = entry; i < items.Length; i++)
            {
                int current = items[i];
                if (itemType == "cheap")
                {
                    if (current < entryPrice)
                    {
                        rightPrice += current;
                    }
                
                }
                else
                {
                    if (current >= entryPrice)
                    {
                        rightPrice += current;
                    }
                }
            }

            if (leftPrice >= rightPrice)
            {
                Console.WriteLine($"Left - {leftPrice}");
            }
            else
            {
                Console.WriteLine($"Right - {rightPrice}");
            }
        }
    }
}
