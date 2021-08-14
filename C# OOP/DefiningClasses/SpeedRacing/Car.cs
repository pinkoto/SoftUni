using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double Consumption { get; set; }

        public double Traveled { get; set; } = 0;

        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuel;
            this.Consumption = consumption;
        }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * Consumption;
            if (fuelNeeded <= FuelAmount)
            {
                FuelAmount -= fuelNeeded;
                Traveled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
