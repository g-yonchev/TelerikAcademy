/*  Problem 13. Extract students by marks

    Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
    Use LINQ.
*/

namespace ExtractStudentsByMarks
{
    using System;

    using StudentGroups;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Zahari", "Zahariev", new List<int>() { 2, 5, 6 }),
                new Student("Ivan", "Ivanov", new List<int>() { 2 }),
                new Student("Petar", "Dimitrov", new List<int>() { 6, 6, 6 }),
                new Student("Ivan", "Stoyanov", new List<int>() { 2, 5, 5, 5 }),
                new Student("Mariya", "Todorova", new List<int>() { 3, 4, 5 }),
                new Student("Mariya", "Ivanova", new List<int>() { 5, 6 }),
                new Student("Ivan", "Georgiev", new List<int>() { 5 })
            };

            var studentsByExcellentMarks =
                from st in students
                where st.Marks.Contains(6)
                select st;

            foreach (var st in studentsByExcellentMarks)
            {
                Console.WriteLine("{0} {1}, marks: {2}", st.FirstName, st.LastName, string.Join(", ", st.Marks));
            }
        }
    }
}
