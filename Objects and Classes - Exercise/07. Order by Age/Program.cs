using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                if (people.Any(x => x.ID == id))
                {
                    var updatedPerson = people.Where(x => x.ID == id);
                    foreach (var guy in updatedPerson)
                    {
                        guy.Age = age;
                        guy.Name = name;
                    }
                }
                else
                {
                    People person = new People(name, id, age);
                    people.Add(person);
                }
            }
            var orderedPeople = people.OrderBy(x => x.Age);

            foreach (var person in orderedPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public People(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
    }
}
