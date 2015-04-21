/*  Problem 3. First before last

    Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    Use LINQ query operators.
*/

namespace FirstBeforeLastStudent
{
    using System;
    using System.Linq;

    using Student;

    public class TestNames
    {
        static void Main()
        {
            Student[] listOfStudents = new Student[]
            {
                new Student("Petar", "Petrov"),
                new Student("Gosho", "Todorov"),
                new Student("Ivan", "Zahariev"),
                new Student("Zahari", "Ivanov"),
                new Student("Albena", "Albenova"),
                new Student("Albena", "Ivanova"),
                new Student("Ivan", "Albenov")
            };

            var result =
                from st in listOfStudents
                where st.FirstName.ToUpper().CompareTo(st.LastName.ToUpper()) < 0
                select st;

            Student.Information(result);
        }
    }
}
