using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingridientsValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var freshnessValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ingridients = new Queue<int>(ingridientsValues);
            Stack<int> freshnessLevels = new Stack<int>(freshnessValues);
            int sauce = 0;
            int salad = 0;
            int cake = 0;
            int lobster = 0;
            while (ingridients.Count > 0 && freshnessLevels.Count > 0)
            {
                int currIngridient = ingridients.Peek();
                if (currIngridient == 0)
                {
                    ingridients.Dequeue();
                    continue;
                }
                ingridients.Dequeue();
                int currFreshness = freshnessLevels.Pop();
                int score = currIngridient * currFreshness;
                if (score == 150)
                {
                    sauce++;
                }
                else if (score == 250)
                {
                    salad++;
                }
                else if (score == 300)
                {
                    cake++;
                }
                else if (score == 400)
                {
                    lobster++;
                }
                else
                {
                    ingridients.Enqueue(currIngridient + 5);
                }
            }

            if (salad > 0 && sauce > 0 && cake > 0 && lobster > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            if (ingridients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingridients.Sum()}");
            }
            if (cake > 0)
            {
                Console.WriteLine($" # Chocolate cake --> {cake}");
            }
            if (sauce > 0)
            {
                Console.WriteLine($" # Dipping sauce --> {sauce}");
            }
            if (salad > 0)
            {
                Console.WriteLine($" # Green salad --> {salad}");
            }
            if (lobster > 0)
            {
                Console.WriteLine($" # Lobster --> {lobster}");
            }
        }
    }
}
