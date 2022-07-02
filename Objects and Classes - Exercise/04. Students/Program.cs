using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> notOrderedStudents = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                List<string> information = Console.ReadLine().Split().ToList();

                Student student = new Student(information[0], information[1], double.Parse(information[2]));
                notOrderedStudents.Add(student);
            }
            List<Student> orderedStudents = notOrderedStudents.OrderByDescending(notOrderedStudents => notOrderedStudents.Grade).ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
