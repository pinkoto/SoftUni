using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                    
                string[] action = Console.ReadLine().Split();

                if (action[0] == "end")
                {
                    break;
                }

                if (action.Length == 2)
                {
                    train.Add(int.Parse(action[1]));
                }
                else
                {
                    int passengers = int.Parse(action[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        int currentWagon = train[i];
                        if (currentWagon + passengers <= wagonCapacity)
                        {
                            train[i] += passengers;
                            break;
                        }
                        
                    }
                }
            }

                Console.WriteLine(string.Join(" ", train));
            
        }
    }
}
