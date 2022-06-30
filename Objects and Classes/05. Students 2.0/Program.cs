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

                if (IsStudentExisting(students, studentProps[0], studentProps[1]))
                {
                    Students student = GetStudent(students, studentProps[0], studentProps[1]);
                    student.Age = int.Parse(studentProps[2]);
                    student.HomeTown = studentProps[3];
                }
                else
                {
                    Students student = new Students()
                    {
                        FirstName = studentProps[0],
                        LastName = studentProps[1],
                        Age = int.Parse(studentProps[2]),
                        HomeTown = studentProps[3]
                    };
                    students.Add(student);
                }

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

        private static Students GetStudent(List<Students> students, string firstName, string lastName)
        {
            Students existingStudent = null;

            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        private static bool IsStudentExisting(List<Students> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
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
