using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();


            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ");
                if (input[0] == "end")
                {
                    break;
                }
                string course = input[0];
                string student = input[1];

                if (!register.ContainsKey(course))
                {
                    List<string> allStudents = new List<string>();
                    allStudents.Add(student);
                    register.Add(course, allStudents);
                }
                else
                {
                    register[course].Add(student);
                }
            }

            foreach (var course in register)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
