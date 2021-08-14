using System;
using System.Collections.Generic;
using System.Linq;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> idByCompany = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split(" -> ");
                string company = parts[0];
                string id = parts[1];

                if (!idByCompany.ContainsKey(company))
                { 
                    idByCompany.Add(company, new List<string>() { id });
                }
                else
                {
                    if(!idByCompany[company].Contains(id))
                    {
                        idByCompany[company].Add(id);
                    }
                }
            }

            foreach (var kvp in idByCompany)
            {
                Console.WriteLine(kvp.Key);
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
