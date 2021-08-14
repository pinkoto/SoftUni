using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] parts = Console.ReadLine().Split();
                string command = parts[0];

                if (command == "End")
                {
                    break;
                }
                else if (command == "Add")
                {
                    numbers.Add(int.Parse(parts[1]));
                }
                else if (command=="Insert")
                {
                    int idx = int.Parse(parts[2]);

                    if (idx < 0 || idx>=numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        numbers.Insert(idx, int.Parse(parts[1]));
                    }

                }
                else if (command == "Remove")
                {
                    int idx = int.Parse(parts[1]);

                    if (idx < 0 || idx >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(parts[1]));
                    }
                }
                else if (command=="Shift")
                {
                    if (parts[1]=="left")
                    {
                        for (int i = 0; i < int.Parse(parts[2]); i++)
                        {
                            int lastNumber = numbers[0];

                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }

                            numbers[numbers.Count - 1] = lastNumber;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(parts[2]); i++)
                        {
                            int firstNumber = numbers[numbers.Count - 1];

                            for (int j = numbers.Count-1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }

                            numbers[0] = firstNumber;
                        }
                    }
                }
            }


            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
