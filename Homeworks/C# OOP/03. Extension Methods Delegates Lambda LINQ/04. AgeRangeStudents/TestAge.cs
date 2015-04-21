/*  Problem 4. Age range

    Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
*/

namespace AgeRangeStudents
{
    using System;
    using System.Linq;

    using Student;

    class TestAge
    {
        static void Main()
        {
            Student[] listOfStudents = new Student[]
            {
                new Student("Petar", "Petrov", 21),
                new Student("Stamat", "Doichinov", 22),
                new Student("Gosho", "Todorov", 17),
                new Student("Ivan", "Zahariev", 30),
                new Student("Zahari", "Ivanov", 12),
                new Student("Albena", "Albenova", 23),
                new Student("Albena", "Ivanova", 31),
                new Student("Ivan", "Albenov", 18)
            };

            var result =
                from st in listOfStudents
                where (st.Age >= 18 && st.Age <= 24)
                select st;

            Student.Information(result);
        }
    }
}
