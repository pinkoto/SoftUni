using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                family.AddMember(new Person() { Name = input[0], Age = int.Parse(input[1]) });
            }

            foreach (var person in family.GetAllAbove30())
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
