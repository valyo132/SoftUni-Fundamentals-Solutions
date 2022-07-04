using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] line1 = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < line1.Length; i++)
            {
                string[] nameAndMoney = line1[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = nameAndMoney[0];
                decimal money = decimal.Parse(nameAndMoney[1]);

                Person person = new Person(name, money);
                people.Add(person);
            }

            List<Product> products = new List<Product>();

            string[] line2 = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < line2.Length; i++)
            {
                string[] productAndCost = line2[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                string prod = productAndCost[0];
                decimal cost = decimal.Parse(productAndCost[1]);

                Product product = new Product(prod, cost);
                products.Add(product);
            }

            while (true)
            {

                string[] command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }
                string name = command[0];
                string product = command[1];

                var client = people.FindIndex(x => x.Name == name);
                var wantedProduct = products.FindIndex(x => x.Name == product);

                if (people[client].Money >= products[wantedProduct].Cost)
                {
                    Console.WriteLine($"{people[client].Name} bought {products[wantedProduct].Name}");
                    people[client].Money -= products[wantedProduct].Cost;
                    people[client].BagOfProducts.Add(products[wantedProduct]);
                }
                else
                {
                    Console.WriteLine($"{name} can't afford {product}");
                }
            }

            foreach (var item in people)
            {
                if (item.BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{item.Name} - {String.Join(", ", item.BagOfProducts.Select(x => x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> BagOfProducts { get; set; }
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<Product>();
        }
    }
    class Product
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
