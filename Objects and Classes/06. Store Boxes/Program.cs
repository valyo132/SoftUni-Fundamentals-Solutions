using System;
using System.Collections.Generic;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> orders = new List<Box>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] token = command.Split(' ');

                Box box = new Box(int.Parse(token[0]), int.Parse(token[2]));
                box.Item = new Item(token[1], decimal.Parse(token[3]));

                orders.Add(box);
            }

            while (orders.Count > 0)
            {
                decimal max = 0;
                max = FindMaxValue(orders, max);
                PrintTheMostExpensive(orders, max);
            }
        }

        private static decimal FindMaxValue(List<Box> orders, decimal max)
        {
            foreach (var order in orders)
            {
                order.PriceForBox = order.Quantity * order.Item.Price;
                if (order.PriceForBox > max)
                {
                    max = order.PriceForBox;
                }
            }
            return max;
        }

        private static void PrintTheMostExpensive(List<Box> orders, decimal max)
        {
            foreach (var order in orders)
            {
                if (order.PriceForBox == max)
                {
                    Console.WriteLine($"{order.SerialNumber}");
                    Console.WriteLine($"-- {order.Item.Name} - ${order.Item.Price:f2}: {order.Quantity}");
                    Console.WriteLine($"-- ${order.PriceForBox:f2}");

                    orders.Remove(order);
                    break;
                }
            }
        }
    }
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceForBox { get; set; }

        public Box(int serialNumber, int quantity)
        {
            SerialNumber = serialNumber;
            Quantity = quantity;
        }
    }
}
