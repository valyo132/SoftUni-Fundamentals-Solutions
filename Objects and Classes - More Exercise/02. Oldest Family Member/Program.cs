using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());

            Family fullFamily = new Family();

            for (int i = 0; i < countOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                fullFamily.AddMember(person);
            }
            Person oldestMember = fullFamily.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    class Family
    {
        public List<Person> People { get; set; }
        public Family()
        {
            this.People = new List<Person>();
        }

        public void AddMember(Person person)
        {
            People.Add(person);
        }
        public Person GetOldestMember()
        {
            var oldestMember = People.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestMember;
        }
    }
}
