using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\mcdon\Documents\Pride and Prejudice by Jane Austen.txt");
            List<Student> students = new List<Student>();
                
            Student stud1 = new Student();
            Console.WriteLine($"{stud1.name} has an id of {stud1.id}");
            stud1.name = "Micah";
            stud1.id = 2;

            Student stud2 = new Student("Adam", 1);
            students.Add(stud1);
            students.Add(stud2);

            foreach (var stud in students)
            {
                
                Console.WriteLine(stud);
            }
            DateTime current = DateTime.Now;
            DateTime past = Convert.ToDateTime("1/1/2020");

            var results = current - past;

            Console.WriteLine($"It has been {results.TotalDays} days since the New Year, which was on a {past.DayOfWeek}");

            TimeSpan difference = current - stud1.enrollDate;

            Console.WriteLine($"It has been {difference.TotalMilliseconds} ms since {stud1.name} has enrolled");

            Console.WriteLine($"There are currently {Student.totalstudents} enrolled");

            //Console.WriteLine($"{stud1.name} has an id of {stud1.id}");
            //Console.WriteLine($"{stud2.name} has an id of {stud2.id}");

            //Dictionary can be used to avoid having to iterate thru a List

        }
    }
}
