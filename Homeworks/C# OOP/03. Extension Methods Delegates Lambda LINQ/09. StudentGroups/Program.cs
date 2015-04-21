/*  Problem 9. Student groups

    Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    Create a List<Student> with sample students. Select only the students that are from group number 2.
    Use LINQ query. Order the students by FirstName.
*/

namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Zahari", "Zahariev", 2),
                new Student("Ivan", "Ivanov", 1),
                new Student("Petar", "Dimitrov", 2),
                new Student("Ivan", "Stoyanov", 3),
                new Student("Mariya", "Todorova", 4),
                new Student("Mariya", "Ivanova", 3),
                new Student("Ivan", "Georgiev", 2)
            };

            var studentsGroupTwo =
                from st in students
                where st.Group == (GroupNumber)2
                select st;

            var orderByFirstName =
                from st in studentsGroupTwo
                orderby st.FirstName
                select st;

            foreach (var st in orderByFirstName)
            {
                Console.WriteLine("{0} {1}, group {2}",st.FirstName, st.LastName, st.Group);
            }
        }
    }
}
