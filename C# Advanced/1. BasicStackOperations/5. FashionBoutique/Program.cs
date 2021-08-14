using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothesStack = new Stack<int>(clothes);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 0;
            int currentRackCapLeft = capacity;

            while (clothesStack.Any())
            {
                if (racks == 0) racks++;
                if (currentRackCapLeft >=clothesStack.Peek())
                {
                    currentRackCapLeft -= clothesStack.Pop();
                }   
            }

            Console.WriteLine("Hello World!");
        }
    }
}
