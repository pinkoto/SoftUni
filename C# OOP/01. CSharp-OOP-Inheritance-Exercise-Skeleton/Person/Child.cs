using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public override int Age
        {
            get => base.Age;
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException();
                }
                base.Age = value;
            }
        }
        public Child(string name, int age) : base(name, age)
        {
            Age = age;
        }
    }
}
