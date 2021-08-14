using System;
using System.Linq;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[i] = rowData;
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }


            }
        }
    }
}
