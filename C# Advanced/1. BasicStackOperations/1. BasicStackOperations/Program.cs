using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._BasicStackOperations
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
            Stack<int> numStack = new Stack<int>(numbers);

            for (int i = 0; i < parameters[1]; i++)
            {
                numStack.Pop();
            }

            if (numStack.Contains(parameters[2]))
            {
                Console.WriteLine("true");
            }
            else if (numStack.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numStack.Min());
            }

        }
    }
}
