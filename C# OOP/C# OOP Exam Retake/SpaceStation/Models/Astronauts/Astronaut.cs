using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Models.Bags.Contracts;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private string name;
        private double oxygen;
        private Backpack backpack;

        public Astronaut(string name, double oxygen)
        {
            Name = name;
            Oxygen = oxygen;
            backpack = new Backpack();
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidAstronautName);
                }
                else
                {
                    name = value;
                }
            }
        }

        public double Oxygen
        {
            get => oxygen;
            protected set
            {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }
                else
                {
                    oxygen = value;
                }
            }
        }

        public bool CanBreath => Oxygen > 0 ? true : false;

        public IBag Bag => backpack;

        public virtual void Breath()
        {
            Oxygen -= 10;
        }
    }
}
