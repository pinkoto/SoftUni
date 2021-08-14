using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexExercice

{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@">>(?<name>[A-Za-z0-9]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)");
            List<string> furnitures = new List<string>();
            double sum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }

                Match match = pattern.Match(input);

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                furnitures.Add(name);
                sum += price * quantity; 
            }


            Console.WriteLine("Bought furniture:");
            foreach (string item in furnitures)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
