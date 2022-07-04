using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < countOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo);

                cars.Add(car);
            }

            string line = Console.ReadLine();

            if (line == "fragile")
            {
                var fragileCars = cars.Where(x => x.Cargo.Weight < 1000).ToList();

                foreach (var car in fragileCars)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else if (line == "flamable")
            {
                var flamableCars = cars.Where(x => x.Engine.Power > 250).ToList();

                foreach (var car in flamableCars)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            Cargo = cargo;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
        public Engine(int speed, int power)
        {
            this.Power = power;
            this.Speed = speed;
        }
    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
        public Cargo(int weigth, string type)
        {
            this.Type = type;
            this.Weight = weigth;
        }
    }
}
