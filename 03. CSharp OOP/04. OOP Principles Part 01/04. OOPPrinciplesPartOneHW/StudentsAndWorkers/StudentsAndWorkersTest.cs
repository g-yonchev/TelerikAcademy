/*  Problem 2. Students and workers

    Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
    Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
    Initialize a list of 10 workers and sort them by money per hour in descending order.
    Merge the lists and sort them by first name and last name.
*/
namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsAndWorkersTest
    {
        public static Random randNum = new Random();
        public static Random r = new Random();

        static void Main()
        {
            double minGrade = 0;
            double maxGrade = 100;

            double minSalary = 350;
            double maxSalary = 2500;

            double minWorkHoursPerDay = 4;
            double maxWorkHoursPerDay = 10;

            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student currentStudent =
                    new Student(GetRandomName(), GetRandomName(), GetRandomNumber(minGrade, maxGrade));
                students.Add(currentStudent);
            }

            var sortedStudents = students
                .OrderBy(st => st.Grade)
                .ToList();

            // Print Students
            //Console.WriteLine("Students:");
            //foreach (Student student in sortedStudents)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            for (int i = 0; i < 10; i++)
            {
                Worker currentWorker =
                    new Worker(GetRandomName(), GetRandomName(), GetRandomNumber(minSalary, maxSalary), GetRandomNumber(minWorkHoursPerDay, maxWorkHoursPerDay));
                workers.Add(currentWorker);
            }

            var sortedWorkers = workers
                .OrderByDescending(w => w.MoneyPerHour())
                .ToList();

            // Print Workers
            //Console.WriteLine("Workers:");
            //foreach (Worker worker in sortedWorkers)
            //{
            //    Console.WriteLine(worker);
            //}
            //Console.WriteLine();

            var mergedPeople = new List<Human>();
            mergedPeople.AddRange(sortedStudents);
            mergedPeople.AddRange(sortedWorkers);

            var result = mergedPeople
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            // Print All
            //Console.WriteLine("Merged:");
            //foreach (Human human in result)
            //{
            //    Console.WriteLine(human);
            //}

        }

        static double GetRandomNumber(double minimum, double maximum)
        {
            return randNum.NextDouble() * (maximum - minimum) + minimum;
        }

        static string GetRandomName()
        {
            string alphabet = "abcdefghijklmnopqrstuvwyxzeeeiouea";
            Func<char> randomLetter = () => alphabet[r.Next(alphabet.Length)];
            Func<int, string> makeName =
              (length) => new string(Enumerable.Range(0, length)
                 .Select(x => x == 0 ? char.ToUpper(randomLetter()) : randomLetter())
                 .ToArray());
            string name = makeName(r.Next(5) + 5);

            return name;
        }
    }
}

