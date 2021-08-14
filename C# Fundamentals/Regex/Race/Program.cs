using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex nameRegex = new Regex(@"[A-Za-z]+");
            Regex scoreRegex = new Regex(@"\d");

            Dictionary<string, int> racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }

                MatchCollection nameMatches = nameRegex.Matches(input);

                string name = GetName(nameMatches);

                MatchCollection scoreMathes = scoreRegex.Matches(input);

                int score = GetScore(scoreMathes);

                if (!racers.ContainsKey(name))
                {
                    continue;
                }

                racers[name] += score;
            }

            string[] winners = racers
                .OrderByDescending(s => s.Value)
                .Select(n => n.Key)
                .Take(3)
                .ToArray();

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");
        }

        private static int GetScore(MatchCollection scoreMathes)
        {
            int sum = 0; 

            foreach (Match match in scoreMathes)
            {
                sum += int.Parse(match.Value);
            }

            return sum;
        }

        private static string GetName(MatchCollection nameMatches)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Match match in nameMatches)
            {
                sb.Append(match.Value);
            }

            return sb.ToString();
        }
    }
}
