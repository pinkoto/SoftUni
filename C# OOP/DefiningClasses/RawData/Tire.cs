using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public double Pressure { get; set; }

        public double Age { get; set; }

        public Tire(double tirePressure, double tireAge)
        {
            Pressure = tirePressure;
            Age = tireAge;
        }
    }
}
