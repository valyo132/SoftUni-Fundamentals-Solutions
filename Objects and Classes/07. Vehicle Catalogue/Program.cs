using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] token = command.Split('/');

                if (token[0] == "Car")
                {
                    Car car = new Car(token[1], token[2], int.Parse(token[3]));
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(token[1], token[2], double.Parse(token[3]));
                    trucks.Add(truck);
                }
            }
            List<Car> orderedCars = cars.OrderBy(car => car.Brand).ToList();
            List<Truck> orderedTrucks = trucks.OrderBy(truck => truck.Brand).ToList();

            Catalog catalog = new Catalog(orderedTrucks, orderedCars);
            if (orderedCars.Count >= 1)
            {
                PrintCars(catalog);
            }
            if (orderedTrucks.Count >= 1)
            {
                PrintTrucks(catalog);
            }
        }

        private static void PrintTrucks(Catalog catalog)
        {
            Console.WriteLine("Trucks:");
            foreach (var item in catalog.Trucks)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
            }
        }

        private static void PrintCars(Catalog catalog)
        {
            Console.WriteLine("Cars:");
            foreach (var item in catalog.Cars)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
        public Truck(string brand, string model, double weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
    }
    class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
        public Catalog(List<Truck> trucks, List<Car> cars)
        {
            Trucks = trucks;
            Cars = cars;
        }
    }
}
