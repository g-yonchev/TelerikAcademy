/*  Problem 11. Extract students by email

    Extract all students that have email in abv.bg.
    Use string methods and LINQ.
*/

namespace ExtractStudentsByEmail
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
                new Student("Zahari", "Zahariev", "zz@abv.bg"),
                new Student("Ivan", "Ivanov", "ii@gmail.com"),
                new Student("Petar", "Dimitrov", "pd@abv.bg"),
                new Student("Ivan", "Stoyanov", "is@abv.bg"),
                new Student("Mariya", "Todorova", "mt@mail.bg"),
                new Student("Mariya", "Ivanova", "mariyaivanova@abv.com"),
                new Student("Ivan", "Georgiev", "ivang@hotmail.com")
            };

            var studentsByEmail = 
                from st in students
                where st.Email.Substring((st.Email.IndexOf("@") + 1)) == "abv.bg"
                select st;

            var studentsByEmail2 = students
                .Where(st => st.Email.Contains("abv.bg"));

            foreach (var st in studentsByEmail)
            {
                Console.WriteLine("{0} {1}, {2}", st.FirstName, st.LastName, st.Email);
            }
        }
    }
}
