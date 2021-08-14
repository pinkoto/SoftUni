using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> numQueue = new Queue<int>(numbers);

            for (int i = 0; i < parameters[1]; i++)
            {
                numQueue.Dequeue();
            }

            if (numQueue.Contains(parameters[2]))
            {
                Console.WriteLine("true");
            }
            else if (numQueue.Count<=0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numQueue.Min());
            }
        }
    }
}
