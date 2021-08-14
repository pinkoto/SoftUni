using System;
using System.Linq;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] first = new string[n];
            string[] second = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    second[i] = input[0];
                    first[i] = input[1];
                }
                else
                {
                    first[i] = input[0];
                    second[i] = input[1];
                }
            }

            foreach (string item in second)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            foreach (string item in first)
            {
                Console.Write(item+" ");
            }
        }
    }
}
