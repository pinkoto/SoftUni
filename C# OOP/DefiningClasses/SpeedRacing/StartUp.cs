using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ");
                cars[i] = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            }

            while (true)
            {
                string[] line = Console.ReadLine().Split(" ");
                if (line[0]=="End")
                {
                    break;
                }

                string model = line[1];
                double distance = double.Parse(line[2]);
                cars.Where(c => c.Model == model).ToList().ForEach(c => c.Drive(distance));
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Traveled}");
            }
        }
    }
}
