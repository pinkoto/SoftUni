﻿using System;
using System.Collections.Generic;

namespace _1.Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string uName = Console.ReadLine();
                usernames.Add(uName);
            }
            foreach (var name in usernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
