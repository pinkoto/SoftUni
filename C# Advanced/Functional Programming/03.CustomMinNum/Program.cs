using System;
using System.Linq;

namespace _03.CustomMinNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(input.Min());
        }
    }
}
