using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork
{
    class Program
    {
        class Team
        {
            public string Name { get; set; }

            public string Creator { get; set; }

            public List<string> Members { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


            }
        }
    }
}
