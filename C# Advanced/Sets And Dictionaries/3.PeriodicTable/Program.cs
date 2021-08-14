using System;
using System.Collections.Generic;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] el = Console.ReadLine().Split();
                foreach  (var e in el)
                {
                    elements.Add(e);
                }
            }

            Console.WriteLine(string.Join(" ",elements));
        }
        
    }
}
