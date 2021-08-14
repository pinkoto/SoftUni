using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line=="end")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];
                string value = parts[1];

                if (command=="Delete")
                {
                    numbers.Remove(value);
                }
                else
                {
                    numbers.Insert(int.Parse(parts[2]), value);
                }

            }


            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
