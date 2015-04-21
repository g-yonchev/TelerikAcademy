/*  Problem 14. Extract students with two marks

    Write down a similar program that extracts the students with exactly two marks "2".
    Use extension methods.
*/

namespace ExtractStudentsWithTwoMarks
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
                new Student("Zahari", "Zahariev", new List<int>() { 2, 5, 6 }),
                new Student("Ivan", "Ivanov", new List<int>() { 2 }),
                new Student("Petar", "Dimitrov", new List<int>() { 6, 6, 6 }),
                new Student("Ivan", "Stoyanov", new List<int>() { 2, 5, 5, 5 }),
                new Student("Mariya", "Todorova", new List<int>() { 3, 4, 5 }),
                new Student("Mariya", "Ivanova", new List<int>() { 5, 6 }),
                new Student("Ivan", "Georgiev", new List<int>() { 5 })
            };

            var studentsWithTwoMarks =
                from st in students
                where st.Marks.Count == 2
                select st;

            foreach (var st in studentsWithTwoMarks)
            {
                Console.WriteLine("{0} {1}, marks: {2}", st.FirstName, st.LastName, string.Join(", ", st.Marks));
            }
        }
    }
}

