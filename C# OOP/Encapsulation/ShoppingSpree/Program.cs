using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            var productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < peopleInput.Length; i++)
            {
                try
                {
                var tokens = peopleInput[i].Split("=");
                people.Add(new Person(tokens[0], int.Parse(tokens[1])));

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            for (int i = 0; i < productsInput.Length; i++)
            {
                try
                {
                var tokens = productsInput[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                products.Add(new Product(tokens[0], int.Parse(tokens[1])));

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            while (true)
            {
                var tokens = Console.ReadLine().Split();
                if (tokens[0]=="END")
                {
                    break;
                }

                string buyerName = tokens[0];
                string item = tokens[1];

                Product product = products.Find(p => p.Name == item);
                Person buyer = people.Find(b => b.Name == buyerName);
                if (buyer==null)
                {
                    break;
                }
                if (buyer.Money >= product.Cost)
                {
                    buyer.products.Add(product);
                    buyer.Withdraw(product.Cost);
                    Console.WriteLine($"{buyerName} bought {item}");
                }
                else
                {
                    Console.WriteLine($"{buyerName} can't afford {item}");
                }
            }

            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");
                if (person.products.Count==0)
                {
                    Console.Write("Nothing bought");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", person.products));
                }
            }
        }
    }
}
