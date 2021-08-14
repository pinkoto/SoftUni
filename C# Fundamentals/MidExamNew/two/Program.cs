using System;
using System.Collections.Generic;
using System.Linq;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "No Money")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];
                string gift = parts[1];

                if (command == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Count; i++)
                    {
                        if (gifts[i] == gift)
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (command == "Required")
                {
                    int idx = int.Parse(parts[2]);

                    if (idx >= 0 && idx < gifts.Count)
                    {
                        gifts[idx] = gift;
                    }
                }
                else
                {
                    gifts[gifts.Count - 1] = gift;
                }
            }

            for (int i = 0; i < gifts.Count; i++)
            {
                if (gifts[i] == "None")
                {
                    continue;
                }
                else
                {
                    Console.Write(gifts[i] + " ");
                }
            }
        }
    }
}
