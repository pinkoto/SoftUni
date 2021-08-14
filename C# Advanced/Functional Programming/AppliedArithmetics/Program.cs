using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Action<int[]> print = n => Console.WriteLine(string.Join(" ", n));
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "add":
                        numbers = ForEach(numbers, n => n + 1);
                        break;
                    case "multiply":
                        numbers = ForEach(numbers, n => n * 2);
                        break;
                    case "subtract":
                        numbers = ForEach(numbers, n => n - 1);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }
            }
        }

        public static int[] ForEach(int[] numbers, Func<int, int> func) =>
            numbers.Select(n => func(n)).ToArray();
    }
}
