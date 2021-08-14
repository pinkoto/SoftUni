using System;
using System.Linq;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int height = size[0];
            int width = size[1];
            char[,] matrix = new char[height, width];

            for (int i = 0; i < height; i++)
            {
                char[] rowData = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = rowData[j];
                }
            }

            int squaresFound = 0;
            if (matrix.Length != 0)
            {
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    {
                        char currChar = matrix[i, j];
                        if (currChar == matrix[i, j + 1] &&
                            currChar == matrix[i + 1, j] &&
                            currChar == matrix[i + 1, j + 1])
                        {
                            squaresFound++;
                        }
                    }
                }
            }

            Console.WriteLine(squaresFound);
        }
    }
}
