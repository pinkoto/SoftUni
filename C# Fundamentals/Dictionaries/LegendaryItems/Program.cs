using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryItems
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();
            bool isCrafted = false;

            while (!isCrafted)
            {
                string[] parts = Console.ReadLine().Split();
                for (int i = 0; i < parts.Length; i += 2)
                {
                    int quantity = int.Parse(parts[i]);
                    string item = parts[i + 1].ToLower();

                    if (legendaryItems.ContainsKey(item))
                    {
                        legendaryItems[item] += quantity;

                        if (legendaryItems["motes"] >= 250)
                        {
                            legendaryItems["motes"] -= 250;
                            Console.WriteLine("Dragonwrath obtained!");
                            isCrafted = true;
                            break;
                        }
                        else if (legendaryItems["fragments"] >= 250)
                        {
                            legendaryItems["fragments"] -= 250;
                            Console.WriteLine("Valanyr obtained!");
                            isCrafted = true;
                            break;
                        }
                        else if (legendaryItems["shards"] >= 250)
                        {
                            legendaryItems["shards"] -= 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            isCrafted = true;
                            break;
                        }


                    }
                    else
                    {
                        if (junkItems.ContainsKey(item))
                        {
                            junkItems[item] += quantity;
                        }
                        else
                        {
                            junkItems.Add(item, quantity);
                        }
                    }

                }

            }

            legendaryItems = legendaryItems
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in legendaryItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
