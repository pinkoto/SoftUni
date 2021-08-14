using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();
            while (heroes.Count!=heroesCount)
            {
                try
                {
                    string name = Console.ReadLine();
                    string type = Console.ReadLine();
                    if (type == "Druid")
                    {
                        heroes.Add(new Druid(name));
                    }
                    else if (type == "Paladin")
                    {
                        heroes.Add(new Paladin(name));
                    }
                    else if (type == "Rogue")
                    {
                        heroes.Add(new Rogue(name));
                    }
                    else if (type == "Warrior")
                    {
                        heroes.Add(new Warrior(name));
                    }
                    else
                    {
                        throw new ArgumentException("Invalid hero!");
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            int bossHP = int.Parse(Console.ReadLine());
            foreach (BaseHero hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int heroesAttack = heroes
                .Sum(x => x.Power);
            if (heroesAttack>=bossHP)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
