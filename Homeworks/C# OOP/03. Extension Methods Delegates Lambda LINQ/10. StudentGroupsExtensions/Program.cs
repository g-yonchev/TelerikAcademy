/*  Problem 10. Student groups extensions

    Implement the previous using the same query expressed with extension methods.
*/

namespace StudentGroupsExtensions
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
                new Student("Zahari", "Zahariev", 2),
                new Student("Ivan", "Ivanov", 1),
                new Student("Petar", "Dimitrov", 2),
                new Student("Ivan", "Stoyanov", 3),
                new Student("Mariya", "Todorova", 4),
                new Student("Mariya", "Ivanova", 3),
                new Student("Ivan", "Georgiev", 2)
            };

            var studentsGroupTwoOrderByName = students
                .Where(st => st.Group == (GroupNumber)2)
                .OrderBy(st => st.FirstName);

            foreach (var st in studentsGroupTwoOrderByName)
            {
                Console.WriteLine("{0} {1}, group {2}", st.FirstName, st.LastName, st.Group);
            }
        }
    }
}
