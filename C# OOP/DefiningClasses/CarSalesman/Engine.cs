using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {Model}:");
            sb.AppendLine($"    Power: {Power}");
            sb.AppendLine(Displacement == 0 ? "    Displacement: n/a" : $"    Displacement: {Displacement}");
            sb.AppendLine(Efficiency == null ? "    Efficiency: n/a" : $"    Efficiency: {Efficiency}");

            return sb.ToString().TrimEnd();
        }
    }
}
