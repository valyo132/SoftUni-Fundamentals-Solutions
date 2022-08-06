using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> sckolo = new Dictionary<string, List<double>>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!sckolo.ContainsKey(studentName))
                {
                    List<double> grades = new List<double> { grade };
                    sckolo.Add(studentName, grades);
                }
                else
                {
                    sckolo[studentName].Add(grade);
                }
            }

            foreach (var student in sckolo)
            {
                var avarage = sckolo[student.Key].Average(x => x);

                if (avarage >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {avarage:f2}");
                }
            }
        }
    }
}
