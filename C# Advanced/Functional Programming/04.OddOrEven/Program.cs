using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string querry = Console.ReadLine();
            Predicate<int> predicate = querry == "odd"
                ? n => n % 2 != 0
                : new Predicate<int>(n => n % 2 == 0);

            List<int> numbers = new List<int>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (predicate(i))
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
