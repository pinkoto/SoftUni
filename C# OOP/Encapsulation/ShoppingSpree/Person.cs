using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        private string name;
        private int money;
        public List<Product> products;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public int Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public void Withdraw(int amount) => Money -= amount;
    }
}
