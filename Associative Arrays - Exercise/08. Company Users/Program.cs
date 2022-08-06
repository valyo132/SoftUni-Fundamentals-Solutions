using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" -> ");
                if (command[0] == "End")
                {
                    break;
                }
                string nameOfCompany = command[0];
                string employeeID = command[1];

                if (!company.ContainsKey(nameOfCompany))
                {
                    List<string> employees = new List<string> { employeeID };
                    company.Add(nameOfCompany, employees);
                }
                else
                {
                    if (!company[nameOfCompany].Contains(employeeID))
                    {
                        company[nameOfCompany].Add(employeeID);
                    }
                }
            }

            foreach (var name in company)
            {
                Console.WriteLine($"{name.Key}");

                foreach (var worker in name.Value)
                {
                    Console.WriteLine($"-- {worker}");
                }
            }
        }
    }
}
