using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                var engineInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                engines.Add(CreateEngine(engineInfo));
            }

            int m = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                cars.Add(CreateCar(carInfo, engines));
            }
            foreach (var car in cars)
            {
               Console.WriteLine(car.ToString());
            }
        }

        private static Car CreateCar(string[] carInfo, List<Engine> engines)
        {
            Engine engine = engines.Find(m => m.Model == carInfo[1]);
            var car = new Car(carInfo[0],engine);
            if (carInfo.Length > 2)
            {
                var isNum = int.TryParse(carInfo[2], out int weight);
                if (isNum)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carInfo[2];
                }
                if (carInfo.Length > 3)
                {
                    car.Color = carInfo[3];
                }
            }
            return car;
        }

        private static Engine CreateEngine(string[] engineInfo)
        {
            var eng = new Engine(engineInfo[0], int.Parse(engineInfo[1]));
            if (engineInfo.Length>2)
            {
                bool isNum = int.TryParse(engineInfo[2], out int disp);
                if (isNum)
                {
                    eng.Displacement = disp;
                }
                else
                {
                    eng.Efficiency = engineInfo[2];
                }
                if (engineInfo.Length>3)
                {
                    eng.Efficiency = engineInfo[3];
                }
            }
            return eng;
        }
    }
}
