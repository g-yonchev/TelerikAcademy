/* Problem 15. Extract marks

    Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
*/

namespace ExtractMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using StudentGroups;

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Zahari","Zahariev","121206",new List<int>(){2,3}),
                new Student("Zahari", "Zahariev", "121206", new List<int>() { 2, 5, 6 }),
                new Student("Ivan", "Ivanov", "131205", new List<int>() { 2 }),
                new Student("Petar", "Dimitrov", "111006", new List<int>() { 6, 6, 6 }),
                new Student("Ivan", "Stoyanov", "150306", new List<int>() { 2, 5, 5, 5 }),
                new Student("Mariya", "Todorova", "150305", new List<int>() { 3, 4, 5 }),
                new Student("Mariya", "Ivanova", "121201", new List<int>() { 5, 6 }),
                new Student("Ivan", "Georgiev", "101006", new List<int>() { 5 })
            };

            var studentsMarksByYear = students
                .Where(st => st.Fn.Substring(4, 2) == "06")
                .Select(st => st.Marks);

            var marks = new List<int>();

            foreach (var mark in studentsMarksByYear)
            {
                marks.AddRange(mark);
            }

            Console.WriteLine(string.Join(", ", marks));

        }
    }
}
