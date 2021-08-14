using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0]=="Tournament")
                {
                    break;
                }

                string name = input[0];
                if (!trainers.Any(n=>n.Name==name))
                {
                    trainers.Add(new Trainer(name));
                }

                var currTrainer = trainers.Find(n => n.Name == name);
                currTrainer.Pokemons.Add(new Pokemon(input[1], input[2], int.Parse(input[3])));
            }

            while (true)
            {
                var element = Console.ReadLine();
                if (element == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p=>p.Element==element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;
                            if (trainer.Pokemons[i].Health<=0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
