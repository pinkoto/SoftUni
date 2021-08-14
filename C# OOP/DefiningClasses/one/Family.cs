using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private readonly HashSet<Person> members;

        public Family()
        {
            members = new HashSet<Person>();
        }

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public Person GetOldestMember()
        {
            Person person = members.OrderByDescending(p => p.Age).FirstOrDefault();
            return person;

        }

        public HashSet<Person> GetAllAbove30()
            => this.members.Where(p => p.Age > 30).OrderBy(n => n.Name).ToHashSet();
    }
}
