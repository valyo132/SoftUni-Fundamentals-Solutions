using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            while (true)
            {
                string[] vihicleInformation = Console.ReadLine().Split();
                if (vihicleInformation[0] == "End")
                {
                    break;
                }

                string typeOfVehicle = vihicleInformation[0];
                string model = vihicleInformation[1];
                string color = vihicleInformation[2];
                int horsepower = int.Parse(vihicleInformation[3]);

                if (typeOfVehicle == "car")
                {
                    Vehicle newCar = new Vehicle(typeOfVehicle, model, color, horsepower);
                    cars.Add(newCar);
                }
                else
                {
                    Vehicle newTruck = new Vehicle(typeOfVehicle, model, color, horsepower);
                    trucks.Add(newTruck);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close the Catalogue")
                {
                    break;
                }
                var carsToPrint = cars.Where(x => x.Model == command);
                var trucksToPrint = trucks.Where(x => x.Model == command);

                foreach (var veh in cars)
                {
                    if (veh.Model == command)
                    {
                        foreach (var car in carsToPrint)
                        {
                            Console.WriteLine($"Type: Car" +
                                 $"\nModel: {car.Model}" +
                                 $"\nColor: {car.Color}" +
                                 $"\nHorsepower: {car.HorsePower}");
                        }
                    }
                }
                foreach (var veh in trucks)
                {
                    if (veh.Model == command)
                    {
                        foreach (var truck in trucksToPrint)
                        {
                            Console.WriteLine($"Type: Truck" +
                                 $"\nModel: {truck.Model}" +
                                 $"\nColor: {truck.Color}" +
                                 $"\nHorsepower: {truck.HorsePower}");
                        }
                    }
                }
            }

            double avarageHorsePowerOfTheCars = 0;
            int carsCount = 0;
            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    avarageHorsePowerOfTheCars += car.HorsePower;
                    carsCount++;
                }
                avarageHorsePowerOfTheCars /= carsCount;
            }
            Console.WriteLine($"Cars have average horsepower of: {avarageHorsePowerOfTheCars:f2}.");

            double avarageHorsePowerOfTheTrucks = 0;
            int trucksCount = 0;
            if (trucks.Count > 0)
            {
                foreach (var truck in trucks)
                {
                    avarageHorsePowerOfTheTrucks += truck.HorsePower;
                    trucksCount++;
                }
                avarageHorsePowerOfTheTrucks /= trucksCount;
            }
            Console.WriteLine($"Trucks have average horsepower of: {avarageHorsePowerOfTheTrucks:f2}.");
        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
    }
}
