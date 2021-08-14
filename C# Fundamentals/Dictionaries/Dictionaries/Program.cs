using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string line = Console.ReadLine();


            foreach (char letter in line)
            {
                if (letter == ' ')
                {
                    continue;
                }

                if (letters.ContainsKey(letter))
                {
                    letters[letter]++;
                }
                else
                {
                    letters.Add(letter, 1);
                }
            }

            foreach (var symbol in letters)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }

        }
    }
}
