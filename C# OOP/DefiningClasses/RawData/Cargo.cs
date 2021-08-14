using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public double Weight { get; set; }

        public string Type { get; set; }

        public Cargo(double cargoWeight, string cargoType)
        {
            Weight = cargoWeight;
            Type = cargoType;
        }
    }
}
