
using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle
    {
        private double ACConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + ACConsumption;
    }
}
