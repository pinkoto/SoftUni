using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string vehicle = tokens[1];
                double amount = double.Parse(tokens[2]);
                try
                {

                    if (vehicle == "Car")
                    {
                        if (command == "Drive")
                        {
                            Drive(car, amount);
                        }
                        else if (command == "Refuel")
                        {
                            car.Refuel(amount);
                        }
                    }
                    else if (vehicle == "Truck")
                    {
                        if (command == "Drive")
                        {
                            Drive(truck, amount);
                        }
                        else if (command == "Refuel")
                        {
                            truck.Refuel(amount);
                        }
                    }
                    else if (vehicle == "Bus")
                    {
                        if (command == "Drive")
                        {
                            bus.IsEmpty = false;
                            Drive(bus, amount);
                        }
                        else if (command == "Refuel")
                        {
                            bus.Refuel(amount);
                        }
                        else
                        {
                            bus.IsEmpty = true;
                            Drive(bus, amount);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }


        public static void Drive(Vehicle vehicle, double distance)
        {
            bool canDrive = vehicle.CanDrive(distance);
            string vehicleType = vehicle.GetType().Name;
            Console.WriteLine(canDrive ? $"{vehicleType} travelled {distance} km" : $"{vehicleType} needs refueling");
        }
    }
}
