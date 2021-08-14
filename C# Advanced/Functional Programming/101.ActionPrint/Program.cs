using System;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printNames = n => Console.WriteLine($"Sir {n}");
            Console.ReadLine().Split().ToList().ForEach(printNames);
        }
    }
}
