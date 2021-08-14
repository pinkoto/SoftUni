using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        public double Speed { get; set; }

        public double Power { get; set; }

        public Engine(double engineSpeed, double enginePower)
        {
            Speed = engineSpeed;
            Power = enginePower;
        }
    }
}
