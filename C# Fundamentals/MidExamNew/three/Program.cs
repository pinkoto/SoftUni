using System;
using System.Collections.Generic;
using System.Linq;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Done")
                {
                    break;
                }

                string[] parts = line.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                string[] subparts = parts[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = subparts[0];

                if (command == "Add")
                {
                    string title = parts[1];
                    if (!books.Contains(title))
                    {
                        books.Insert(0, title);
                    }
                }
                else if (command == "Take")
                {
                    string title = parts[1];
                    if (books.Contains(title))
                    {
                        books.Remove(title);
                    }
                }
                else if (command == "Swap")
                {
                    string firstTitle = parts[1];
                    string secondTitle = parts[2];

                    if (books.Contains(firstTitle) && books.Contains(secondTitle))
                    {
                        int firstIdx = books.IndexOf(firstTitle);
                        int secondIdx = books.IndexOf(secondTitle);

                        string tempBook = books[firstIdx];
                        books[firstIdx] = books[secondIdx];
                        books[secondIdx] = tempBook;
                    }
                }
                else if (command == "Insert")
                {
                    books.Add(parts[1]);
                }
                else
                {
                    int idx = int.Parse(parts[1]);

                    if (idx >= 0 && idx < books.Count)
                    {
                        Console.WriteLine(books[idx]);
                    }
                }

            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
