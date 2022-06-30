using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] studentProps = command.Split(' ');

                Students student = new Students()
                {
                    FirstName = studentProps[0],
                    LastName = studentProps[1],
                    Age = int.Parse(studentProps[2]),
                    HomeTown = studentProps[3]
                };

                students.Add(student);
            }
            string cityName = Console.ReadLine();

            foreach (var student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
