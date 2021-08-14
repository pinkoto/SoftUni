using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> entities = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "End")
                {
                    break;
                }

                if (tokens.Length == 3)
                {
                    rebels.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
                else if (tokens.Length == 4)
                {
                    entities.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }

            }
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                {
                    break;
                }
                Citizen citizen = entities.Find(x => x.Name == name);
                Rebel rebel = rebels.Find(x => x.Name == name);
                if (citizen != null)
                {
                    citizen.BuyFood();
                }
                else if (rebel != null)
                {
                    rebel.BuyFood();
                }
            }

            int food = 0;
            foreach (IBuyer buyer in entities)
            {
                food += buyer.Food;
            }
            foreach (IBuyer buyer in rebels)
            {
                food += buyer.Food;
            }
            Console.WriteLine(food);
        }
    }
}
