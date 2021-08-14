using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divideBy = int.Parse(Console.ReadLine());
            Predicate<int> filter = n => n % divideBy != 0;
            Action<int[]> print = n => Console.WriteLine(string.Join(" ", numbers.Where(num => filter(num)).Reverse()));
            print(numbers);
        }
    }
}
