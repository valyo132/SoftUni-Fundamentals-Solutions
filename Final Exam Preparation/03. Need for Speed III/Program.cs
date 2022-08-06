using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> allCars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInput = Console.ReadLine().Split("|");
                string model = carInput[0];
                int miliage = int.Parse(carInput[1]);
                int fuel = int.Parse(carInput[2]);

                Car newCar = new Car(model, miliage, fuel);
                allCars.Add(newCar);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" : ");
                if (command[0] == "Stop")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Drive":
                        Drive(allCars, command);
                        break;
                    case "Refuel":
                        Refuel(allCars, command);
                        break;
                    case "Revert":
                        Revert(allCars, command);
                        break;
                }
            }

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        private static void Revert(List<Car> allCars, string[] command)
        {
            string model = command[1];
            int kilometers = int.Parse(command[2]);

            Car wantedModel = allCars.Find(x => x.Model == model);
            wantedModel.Mileage -= kilometers;


            if (wantedModel.Mileage < 10000)
            {
                wantedModel.Mileage = 10000;
            }
            else
            {
                Console.WriteLine($"{wantedModel.Model} mileage decreased by {kilometers} kilometers");
            }
        }

        private static void Refuel(List<Car> allCars, string[] command)
        {
            string model = command[1];
            int amount = int.Parse(command[2]);

            Car wantedModel = allCars.Find(x => x.Model == model);

            if (wantedModel.Fuel + amount > 75)
            {
                amount = 75 - wantedModel.Fuel;
                wantedModel.Fuel = 75;
            }
            else
            {
                wantedModel.Fuel += amount;
            }

            Console.WriteLine($"{wantedModel.Model} refueled with {amount} liters");
        }

        private static void Drive(List<Car> allCars, string[] command)
        {
            string model = command[1];
            int distance = int.Parse(command[2]);
            int fuel = int.Parse(command[3]);

            Car wantedModel = allCars.Find(x => x.Model == model);

            if (wantedModel.Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                wantedModel.Fuel -= fuel;
                wantedModel.Mileage += distance;

                Console.WriteLine($"{wantedModel.Model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            }

            if (wantedModel.Mileage >= 100000)
            {
                Console.WriteLine($"Time to sell the {wantedModel.Model}!");
                allCars.Remove(wantedModel);
            }
        }

        class Car
        {
            public string Model { get; set; }
            public int Mileage { get; set; }
            public int Fuel { get; set; }

            public Car(string model, int mileage, int fuel)
            {
                Model = model;
                Mileage = mileage;
                Fuel = fuel;
            }
        }
    }
}
