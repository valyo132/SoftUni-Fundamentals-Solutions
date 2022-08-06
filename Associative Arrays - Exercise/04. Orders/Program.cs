using System;
using System.Collections.Generic;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Prodct> products = new Dictionary<string, Prodct>();

            while (true)
            {
                string[] line = Console.ReadLine().Split();
                if (line[0] == "buy")
                {
                    break;
                }
                string nameOfProduct = line[0];
                double price = double.Parse(line[1]);
                int quantity = int.Parse(line[2]);

                if (!products.ContainsKey(nameOfProduct))
                {
                    Prodct newProduct = new Prodct(price, quantity);
                    products.Add(nameOfProduct, newProduct);
                }
                else
                {
                    products[nameOfProduct].Quantity += quantity;
                    products[nameOfProduct].Price = price;
                }
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value.Price * product.Value.Quantity;
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
        class Prodct
        {
            public double Price { get; set; }
            public int Quantity { get; set; }
            public Prodct(double price, int quantity)
            {
                Price = price;
                Quantity = quantity;
            }
        }
    }
}
