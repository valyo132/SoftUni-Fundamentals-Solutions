using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                double salary = double.Parse(input[1]);
                string depatment = input[2];

                Employee employee = new Employee(name, salary, depatment);
                employees.Add(employee);
            }
            double max = 0;
            string depart = "";

            foreach (var item in employees)
            {
                if (employees.Any(x => x.Department == item.Department))
                {
                    var workersCount = employees.Where(x => x.Department == item.Department).ToList();

                    double result = employees.Where(x => x.Department == item.Department).Sum(y => y.Salary);
                    result /= workersCount.Count;

                    if (result > max)
                    {
                        max = result;
                        depart = item.Department;
                    }
                }
            }
            var orderedSalary = employees.Where(x => x.Department == depart).OrderByDescending(x => x.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {depart}");
            foreach (var item in orderedSalary)
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }
        }
    }
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
