using System;
using System.Linq;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowData[j];
                }
            }

            int pDiagonalSum = 0;
            int sDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                pDiagonalSum += matrix[i, i];
                sDiagonalSum += matrix[i, n - i-1];
            }

            Console.WriteLine(Math.Abs(pDiagonalSum - sDiagonalSum));
        }
    }
}
