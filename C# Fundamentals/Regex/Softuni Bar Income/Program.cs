using System;
using System.Text.RegularExpressions;

namespace Softuni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[^$|%.]*%(?<customerName>[A-Z][a-z]+)%[^$|%.]*<(?<product>\w+)>[^$|%.]*\|(?<quantity>\d+)\|[^$|%.]*?(?<price>\d+\.?\d*)[^$|%.]*\$$");
            double income = 0; 

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }

                Match match = regex.Match(input);
                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["customerName"].Value;
                string product = match.Groups["product"].Value;
                int quantity = int.Parse(match.Groups["quantity"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                double total = quantity * price;
                income += total;

                Console.WriteLine($"{name}: {product} - {total:f2}");

            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
