using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : Vehicle
    {
        private double ACConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + ACConsumption;

        public override void Refuel(double amount)
        {
            if (amount + FuelQuantity > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }
            base.Refuel(amount * 0.95);
        }
    }
}
