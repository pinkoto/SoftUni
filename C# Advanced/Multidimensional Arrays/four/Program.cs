using System;
using System.Linq;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int height = size[0];
            int width = size[1];
            string[,] matrix = new string[height, width];

            for (int i = 0; i < height; i++)
            {
                string[] rowData = Console.ReadLine().Split();
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = rowData[j];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }

                string[] tokens = input.Split();
                if (tokens.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int rowFrom = int.Parse(tokens[1]);
                int colFrom = int.Parse(tokens[2]);
                int rowTo = int.Parse(tokens[3]);
                int colTo = int.Parse(tokens[4]);

                if (!ValidateCoordinates(rowTo, colTo, matrix)||!ValidateCoordinates(rowFrom,colFrom,matrix))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else if (tokens[0] == "swap")
                {
                    string swapTemp = matrix[rowTo, colTo];
                    matrix[rowTo, colTo] = matrix[rowFrom, colFrom];
                    matrix[rowFrom, colFrom] = swapTemp;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i,j]+" ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }

        public static bool ValidateCoordinates(int row, int col, string[,] matrix)
        {
            if (row > matrix.GetLength(0) || col > matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}
