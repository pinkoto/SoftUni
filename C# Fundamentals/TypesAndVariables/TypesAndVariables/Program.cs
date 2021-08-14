using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            long one = long.Parse(Console.ReadLine());
            long two = long.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            long result = (one + two) / three * four;
            Console.WriteLine(result);
        }
    }
}
