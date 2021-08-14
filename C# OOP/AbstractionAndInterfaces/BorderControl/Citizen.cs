using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Citizen : IIdentifiable,IBirthable,IBuyer
    {
        public string Id { get ; set ; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Birthdate { get ; set ; }

        public int Food { get ; set ; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
