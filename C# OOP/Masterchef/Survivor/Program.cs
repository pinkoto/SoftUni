using System;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            var beach = new string[numberOfRows][];
            int myTokens = 0;
            int enemyTokens = 0;
            for (int i = 0;  i < numberOfRows;  i++)
            {
                var rowData = Console.ReadLine().Split();
                beach[i] = rowData;
            }
            while (true)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];
                if (command=="Gong")
                {
                    break;
                }
                var row =int.Parse(input[1]);
                var col =int.Parse( input[2]);
                if (command=="Find")
                {
                    if (ValidCoordinates(beach,row,col))
                    {
                        if (beach[row][col]=="T")
                        {
                            myTokens++;
                            beach[row][col] = "-";
                        }
                    }
                }
                else if (command=="Opponent"&& ValidCoordinates(beach, row, col))
                {
                    var direction = input[3];
                    if (beach[row][col] == "T")
                    {
                        enemyTokens++;
                        beach[row][col] = "-";
                    }
                    switch (direction)
                    {
                        case "up":
                            for (int i = 1; i <= 3; i++)
                            {
                                int newRow = row - i;
                                if (ValidCoordinates(beach, newRow, col))
                                {
                                    if (beach[newRow][col] == "T")
                                    {
                                        enemyTokens++;
                                        beach[newRow][col] = "-";
                                    }
                                }
                            }
                            break;
                        case "down":
                            for (int i = 1; i <= 3; i++)
                            {
                                int newRow = row + i;
                                if (ValidCoordinates(beach, newRow, col))
                                {
                                    if (beach[newRow][col] == "T")
                                    {
                                        enemyTokens++;
                                        beach[newRow][col] = "-";
                                    }
                                }
                            }
                            break;
                        case "left":
                            for (int i = 1; i <= 3; i++)
                            {
                                int newCol = col - i;
                                if (ValidCoordinates(beach, row, newCol))
                                {
                                    if (beach[row][newCol] == "T")
                                    {
                                        enemyTokens++;
                                        beach[row][newCol] = "-";
                                    }
                                }
                            }
                            break;
                        case "right":
                            for (int i = 1; i <= 3; i++)
                            {
                                int newCol = col + i;
                                if (ValidCoordinates(beach, row, newCol))
                                {
                                    if (beach[row][newCol] == "T")
                                    {
                                        enemyTokens++;
                                        beach[row][newCol] = "-";
                                    }
                                }
                            }
                            break;
                    }
                }
            }

            foreach (var beachRow in beach)
            {
                Console.WriteLine(string.Join(" ",beachRow));
            }
            Console.WriteLine($"Collected tokens: {myTokens}");
            Console.WriteLine($"Opponent's tokens: {enemyTokens}");
        }

        private static bool ValidCoordinates(string[][] array, int row, int col)
        {
            if (row>array.Length-1)
            {
                return false;
            }
            if (col > array[row].Length-1)
            {
                return false;
            }
            return true;
        }
    }
}
