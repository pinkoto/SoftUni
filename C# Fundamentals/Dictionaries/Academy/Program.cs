using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> gradeByStudent = new Dictionary<string, List<double>>();
            Dictionary<string, double> avgGrades = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!gradeByStudent.ContainsKey(name))
                {
                    gradeByStudent.Add(name, new List<double>());
                }

                gradeByStudent[name].Add(grade);
            }



            foreach (var kvp in gradeByStudent)
            {
                double avg = kvp.Value.Average();
                avgGrades.Add(kvp.Key, avg);
            }


            avgGrades = avgGrades
                .Where(x => x.Value >= 4.5)
                .OrderByDescending(g => g.Value)
                .ToDictionary(x => x.Key, x => x.Value);


            foreach (var kvp in avgGrades)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
