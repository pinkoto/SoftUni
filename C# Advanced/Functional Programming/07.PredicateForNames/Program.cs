using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.ReadLine().Split().Where(name => name.Length <= n).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
