using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._MaxMinNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numStack = new Stack<int>(n);

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                switch (tokens[0])
                {
                    case "1":
                        numStack.Push(int.Parse(tokens[1]));
                        break;
                    case "2":
                        numStack.Pop();
                        break;
                    case "3":
                        if (numStack.Count > 0)
                        {
                            Console.WriteLine(numStack.Max());
                        }
                        break;
                    case "4":
                        if (numStack.Count > 0)
                        {
                            Console.WriteLine(numStack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numStack));
        }
    }
}
