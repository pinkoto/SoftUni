using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus : Vehicle
    {
        private double ACConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public bool IsEmpty { get; set; }

        public override double FuelConsumption => IsEmpty 
            ? base.FuelConsumption   
            : base.FuelConsumption + ACConsumption;

    }
}
