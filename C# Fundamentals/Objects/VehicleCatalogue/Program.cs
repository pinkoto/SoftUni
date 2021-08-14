using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        class Vehicle
        {
            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public int Horsepower { get; set; }
        }

        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            while (true)
            {
                string[] vehicleInfo = Console.ReadLine()
                    .Split().ToArray();

                if (vehicleInfo[0]=="End")
                {
                    break;
                }

                string type = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2]; 
                int horsepower = int.Parse(vehicleInfo[3]);

                catalogue.Add(new Vehicle()
                {
                    Type = type,
                    Model=model,
                    Color=color,
                    Horsepower=horsepower
                });
            }

            while (true)
            {
                string modelToSearch = Console.ReadLine();
                if (modelToSearch == "Close the Catalogue")
                {
                    break;
                }

                Vehicle vehicle = GetVehicleByModel(catalogue, modelToSearch);
                if (vehicle == null)
                {
                    continue;
                }

                if (vehicle.Type == "car")
                {
                    Console.WriteLine("Type: Car");
                }
                else
                {
                    Console.WriteLine("Type: Truck");

                }
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
            }

            double carsAvgHp = VehicleTypeAvgHp(catalogue, "car");
            double trucksAvgHp = VehicleTypeAvgHp(catalogue, "truck");

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHp:f2}.");
        }

        private static double VehicleTypeAvgHp(List<Vehicle> catalogue, string type)
        {
            int typeCount = 0;
            int typeHpTotal = 0;

            foreach (var vehicle in catalogue)
            {
                if (vehicle.Type==type)
                {
                    typeCount++;
                    typeHpTotal += vehicle.Horsepower;
                }
            }

            if (typeCount==0)
            {
                return 0;
            }
            double avg = (double)typeHpTotal / typeCount;
            return avg;
        }

        private static Vehicle GetVehicleByModel(List<Vehicle> catalogue, string modelToSearch)
        {
            foreach (var vehicle in catalogue)
            {
                if (vehicle.Model==modelToSearch)
                {
                    return vehicle;
                }
            }

            return null;
        }
    }
}
