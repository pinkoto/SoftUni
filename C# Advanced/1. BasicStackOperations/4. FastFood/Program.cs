using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int supply = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ordersQueue = new Queue<int>(orders);
            int sum = 0;

            Console.WriteLine(ordersQueue.Max());

            while (ordersQueue.Count > 0)
            {
                sum += ordersQueue.Peek();

                if (supply >= sum)
                {
                    ordersQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
                    return;
                }

            }
            Console.WriteLine("Orders complete");
            
        }
    }
}
