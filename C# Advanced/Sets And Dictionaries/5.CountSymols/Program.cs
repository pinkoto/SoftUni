using System;
using System.Collections.Generic;

namespace _5.CountSymols
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            foreach (char symbol in line)
            {
                if (!symbols.ContainsKey(symbol))
                {
                    symbols.Add(symbol, 0);
                }
                symbols[symbol]++;
            }
            foreach (var kvp in symbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
