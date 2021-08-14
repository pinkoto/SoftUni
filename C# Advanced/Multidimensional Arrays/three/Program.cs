using System;
using System.Linq;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int height = size[0];
            int width = size[1];
            int[,] matrix = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = rowData[j];
                }
            }

            int maxSum = 0;
            int[] maxSumPos = new int[2];


            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sqareSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sqareSum > maxSum)
                    {
                        maxSum = sqareSum;
                        maxSumPos[0] = i;
                        maxSumPos[1] = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = maxSumPos[0]; i < maxSumPos[0] + 3; i++)
            {
                for (int j = maxSumPos[1]; j < maxSumPos[1] + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
