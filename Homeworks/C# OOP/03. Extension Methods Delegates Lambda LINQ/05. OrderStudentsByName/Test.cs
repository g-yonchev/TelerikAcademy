/*  Problem 5. Order students

    Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
    Rewrite the same with LINQ.
*/

namespace OrderStudentsByName
{
    using System;
    using System.Linq;

    using Student;

    class Test
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

            var resultLambda = listOfStudents
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);

            var resultLINQ =
                from st in listOfStudents
                orderby st.FirstName descending,
                st.LastName descending
                select st;
                
            Console.WriteLine("Lambda: ");
            Student.Information(resultLambda);
            Console.WriteLine("LINQ");
            Student.Information(resultLINQ);
        }
    }
}
