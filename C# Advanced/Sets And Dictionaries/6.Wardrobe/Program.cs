using System;
using System.Collections.Generic;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            FillWardrobe(wardrobe, n);
            string[] clothesToSearch = Console.ReadLine().Split();
            string piece = clothesToSearch[1];
            string color = clothesToSearch[0];
            FindCloth(wardrobe, piece, color);
        }

        public static void FindCloth(Dictionary<string, Dictionary<string, int>> wardrobe, string piece, string color)
        {
            foreach (var currColor in wardrobe)
            {
                Console.WriteLine($"{currColor.Key} clothes:");
                foreach (var cloth in currColor.Value)
                {
                    if (currColor.Key == color && cloth.Key == piece)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }

        public static Dictionary<string, Dictionary<string, int>> FillWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",");
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int cloth = 0; cloth < clothes.Length; cloth++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[cloth]))
                    {
                        wardrobe[color].Add(clothes[cloth], 0);
                    }
                    wardrobe[color][clothes[cloth]]++;
                }
            }

            return wardrobe;
        }
    }
}