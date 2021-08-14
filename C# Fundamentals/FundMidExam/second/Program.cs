using System;
using System.Collections.Generic;
using System.Linq;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] parts = input
                     .Split()
                     .ToArray();
                string command = parts[0];
                if (command == "reverse")
                {
                    int startIdx = int.Parse(parts[2]);
                    int count = int.Parse(parts[4]);
                    if (startIdx<0)
                    {
                        startIdx = 0;
                    }
                    if (count<1)
                    {
                        count = 1;
                    }
                    Reverse(startIdx, count, elements);
                }
                else if (command == "sort")
                {
                    int startIdx = int.Parse(parts[2]);
                    int count = int.Parse(parts[4]);
                    if (startIdx<0)
                    {
                        startIdx = 0;
                    }
                    if (count < 0)
                    {
                        count = 0;
                    }
                    Sort(startIdx, count, elements.Select(int.Parse).ToList());
                }
                else
                {
                    elements.RemoveRange(0, int.Parse(parts[1]));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", elements));

        }

        private static void Sort(int startIdx, int count, List<int> collection)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (collection[startIdx + j] > collection[startIdx + j + 1])
                    {
                        int temp = collection[startIdx + j];
                        collection[startIdx + j] = collection[startIdx + j + 1];
                        collection[startIdx + j + 1] = temp;
                    }
                }
            }
        }

        private static void Reverse(int startIdx, int count, List<string> collection)
        {
            int endIdx = startIdx + count - 1;

            if (count % 2==0)
            {
                for (int i = 0; i < count/2; i++)
                {
                    string temp = collection[startIdx+i];
                    collection[startIdx + i] = collection[endIdx - i];
                    collection[endIdx - i] = temp;
                }
            }
            else
            {
                for (int i = 0; i < count /2-1; i++)
                {
                    string temp = collection[i];
                    collection[startIdx + i] = collection[endIdx - i];
                    collection[endIdx - i] = temp;
                }
            }
        }
    }
}
