using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> entries = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = parts[0];
                string name = parts[1];

                if (command=="register")
                {
                    if (!entries.ContainsKey(name))
                    {
                        entries.Add(name, parts[2]);
                        Console.WriteLine($"{name} registered {entries[name]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {entries[name]}");
                    }
                }
                else
                {
                    if (entries.ContainsKey(name))
                    {
                        if (entries.Remove(name))
                        {
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }

            foreach (var kvp in entries)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
