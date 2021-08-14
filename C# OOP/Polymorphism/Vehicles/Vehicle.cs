using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            private set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public virtual double FuelConsumption { get; }

        public double TankCapacity { get; }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (amount + FuelQuantity > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }
            FuelQuantity += amount;
        }

        public bool CanDrive(double distance)
        {
            if (FuelQuantity >= FuelConsumption * distance)
            {
                FuelQuantity -= distance * FuelConsumption;
                return true;
            }

            return false;
        }
    }
}
