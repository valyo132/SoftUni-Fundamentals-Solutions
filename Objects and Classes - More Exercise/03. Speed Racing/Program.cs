using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCarsToTrack = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < countOfCarsToTrack; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1Km = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1Km, 0);
                cars.Add(car);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Drive")
                {
                    int index = cars.FindIndex(x => x.Model == command[1]);
                    cars[index].Drive(int.Parse(command[2]));
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.TravelDistance}");
            }
        }
        class Car
        {
            public void Drive(int distance)
            {
                double neededFuel = distance * FuelConsumtion;
                if (Fuel >= neededFuel)
                {
                    TravelDistance += distance;
                    Fuel -= neededFuel;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
            public Car(string model, double fuel, double fuelConsumtion, double travelDistance)
            {
                Model = model;
                Fuel = fuel;
                FuelConsumtion = fuelConsumtion;
                TravelDistance = travelDistance;
            }

            public string Model { get; set; }
            public double Fuel { get; set; }
            public double FuelConsumtion { get; set; }
            public double TravelDistance { get; set; }
        }
    }
}
