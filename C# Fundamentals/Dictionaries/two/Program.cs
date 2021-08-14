using System;
using System.Collections.Generic;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resourses = new Dictionary<string, long>();

            while (true)
            {
                string material = Console.ReadLine();
                if (material=="stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (resourses.ContainsKey(material))
                {
                    resourses[material] += quantity;
                }
                else
                {
                    resourses.Add(material, quantity);
                }
            }

            foreach (var resourse in resourses)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
