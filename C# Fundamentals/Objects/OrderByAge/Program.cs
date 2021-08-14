using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Person
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (input[0]=="End")
                {
                    break;
                } 

                string name = input[0];
                int id = int.Parse(input[1]);
                int age = int.Parse(input[2]);

                people.Add(new Person() 
                { 
                    Name=name,
                    Id=id,
                    Age=age
                });

             
            }

            people = people
                 .OrderBy(x => x.Age)
                 .ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
