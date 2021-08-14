using System;
using System.Collections.Generic;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split('|');

            List<string> batches = new List<string>();
            for (int i = arrays.Length-1; i >=0; i--)
            {
                string[] nums = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                batches.AddRange(nums);
            }

            Console.WriteLine(string.Join(" ", batches));
        }
    }
}
