/* Problem 12. Extract students by phone

    Extract all students with phones in Sofia.
    Use LINQ.
*/

namespace ExtractStudentsByPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using StudentGroups;

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {Phone = "02/9882211"},
                new Student {Phone = "+3592 988 23 11"},
                new Student {Phone = "0885 98 22 11"},
                new Student {Phone = "02 988 22 22"},
                new Student {Phone = "056 988 22 11"}
            };

            var studentsByPhone =
                students.Where(st => st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592"));

            foreach (var st in studentsByPhone)
            {
                Console.WriteLine(st.Phone);
            }

        }
    }
}
