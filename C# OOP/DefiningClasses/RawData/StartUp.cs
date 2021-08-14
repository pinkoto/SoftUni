using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Car newCar = new Car(input[0],
                    new Engine(double.Parse(input[1]), double.Parse(input[2])),
                    new Cargo(int.Parse(input[3]), input[4]),
                    new Tire[]
                    {
                        new Tire(double.Parse(input[5]), double.Parse(input[6])),
                        new Tire(double.Parse(input[7]), double.Parse(input[8])),
                        new Tire(double.Parse(input[9]), double.Parse(input[10])),
                        new Tire(double.Parse(input[11]), double.Parse(input[12]))
                    });
                cars.Add(newCar);
            }

            string type = Console.ReadLine();
            List<Car> filtered = new List<Car>();
            if (type=="fragile")
            {
                filtered = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else
            {
                filtered = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList();
            }

            foreach (var car in filtered)
            {
                Console.WriteLine(car.Model) ;
            }
        }
    }
}
