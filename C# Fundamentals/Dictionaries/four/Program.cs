using System;
using System.Collections.Generic;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productByPrice = new Dictionary<string, double>();
            Dictionary<string, int> productByQuantity= new Dictionary<string, int>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line=="buy")
                {
                    break;
                }

                string[] parts = line.Split();
                string name = parts[0];
                double price = double.Parse(parts[1]);
                int quantity =int.Parse(parts[2]);

                if (productByPrice.ContainsKey(name))
                {
                    productByPrice[name] = price;
                    productByQuantity[name] += quantity;
                }
                else
                {
                    productByPrice.Add(name, price);
                    productByQuantity.Add(name, quantity);
                }
            }

            foreach (var item in productByPrice)
            {
                Console.WriteLine($"{item.Key} -> {item.Value*productByQuantity[item.Key]:f2}");   
            }
        }
    }
}
