using System;
using System.Linq;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            while (true)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                if (command == "END")
                {
                    break;
                }
                else if (command=="Push")
                {
                    stack.Push(tokens.Skip(1).Select(e => e.Split(",").First()).ToArray());
                }
                else if (command=="Pop")
                {
                    stack.Pop();
                }
            }

            foreach (string element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (string element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
