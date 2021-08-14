using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public double Grade { get; set; }

            public string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                students.Add(new Student()
                {
                    FirstName = studentInfo[0],
                    LastName = studentInfo[1],
                    Grade = double.Parse(studentInfo[2])
                });

            }

            students = students
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            
        }
    }
}
