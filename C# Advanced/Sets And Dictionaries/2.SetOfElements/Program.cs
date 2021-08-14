using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SetOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<string> one = new HashSet<string>();
            HashSet<string> two = new HashSet<string>();
            for (int i = 0; i < sizes[0]; i++)
            {
                string input = Console.ReadLine();
                one.Add(input);
            }
            for (int i = 0; i < sizes[1]; i++)
            {
                string input = Console.ReadLine();
                two.Add(input);
            }

            foreach (var el in one)
            {
                if (two.Contains(el))
                {
                    Console.Write(el + " ");
                }
            }
        }
    }
}
