using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> membersByCourse = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line=="end")
                {
                    break;
                }

                string[] parts = line.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = parts[0];
                string student = parts[1];

                if (!membersByCourse.ContainsKey(course))
                {
                    membersByCourse.Add(course, new List<string>());
                }
                membersByCourse[course].Add(student);

            }

            Dictionary<string, List<string>> sorted= membersByCourse
                .OrderByDescending(c => c.Value.Count)
                .ToDictionary(x=>x.Key, x=>x.Value);

            foreach (var course in sorted)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                course.Value.Sort();
                 
                foreach (var member in course.Value)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
    }
}
