using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contest> allContests = new List<Contest>();
            List<Student> allStudents = new List<Student>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "no more time")
                {
                    break;
                }
                string username = input[0];
                string contest = input[1];
                int points = int.Parse(input[2]);

                if (!allContests.Any(x => x.ContestName == contest))
                {
                    var newContest = new Contest(contest);
                    allContests.Add(newContest);
                }
                if (!allStudents.Any(x => x.Name == username))
                {
                    var newStudent = new Student(username);
                    allStudents.Add(newStudent);
                }

                Contest currContest = allContests.Find(x => x.ContestName == contest);
                if (currContest.Participants.ContainsKey(username))
                {
                    if (currContest.Participants[username] < points)
                    {
                        currContest.Participants[username] = points;
                    }
                }
                else
                {
                    currContest.Participants.Add(username, points);
                }

                Student currStudent = allStudents.Find(x => x.Name == username);
                if (currStudent.StudentsContests.ContainsKey(contest))
                {
                    if (currStudent.StudentsContests[contest] < points)
                    {
                        currStudent.StudentsContests[contest] = points;
                    }
                }
                else
                {
                    currStudent.StudentsContests.Add(contest, points);
                }
            }

            foreach (var contest in allContests)
            {
                Console.WriteLine($"{contest.ContestName}: {contest.TotalPointsForParticipants} participants");
                int count = 1;
                foreach (var participant in contest.Participants.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"{count}. {participant.Key} <::> {participant.Value}");
                    count++;
                }
            }

            Console.WriteLine("Individual standings:");
            int count1 = 1;
            foreach (var student in allStudents.OrderByDescending(x => x.TotalPoints).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{count1}. {student.Name} -> {student.TotalPoints}");
                count1++;
            }
        }

        class Contest
        {
            public string ContestName { get; set; }
            public Dictionary<string, int> Participants { get; set; }
            public int TotalPointsForParticipants { get { return this.Participants.Count; } }

            public Contest(string contestName)
            {
                ContestName = contestName;
                Participants = new Dictionary<string, int>();
            }
        }

        class Student
        {
            public string Name { get; set; }
            public Dictionary<string, int> StudentsContests { get; set; }
            public int TotalPoints { get { return this.StudentsContests.Values.Sum(); } }

            public Student(string name)
            {
                Name = name;
                StudentsContests = new Dictionary<string, int>();
            }
        }
    }
}
