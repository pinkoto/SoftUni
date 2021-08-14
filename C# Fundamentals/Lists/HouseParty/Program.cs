using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = line[0];

                if (line.Length == 3)
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(name);
                    }
                } 

                
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
