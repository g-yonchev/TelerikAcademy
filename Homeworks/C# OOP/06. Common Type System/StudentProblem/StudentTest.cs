/*  Problem 1. Student class
        Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
        Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

    Problem 2. IClonable
        Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

    Problem 3. IComparable
        Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
*/
namespace StudentProblem
{
    using System;

    public class StudentTest
    {
        public static void Main()
        {
            Student pesho1 = new Student("Pesho", "Petrov", "Ivanov", "123456789");
            Student pesho2 = new Student("Pesho", "Petrov", "Ivanov", "111111111");

            Console.WriteLine(pesho1);
            Console.WriteLine(pesho2);

            Console.WriteLine("They are equals?");

            // Equals
            if (pesho1.Equals(pesho2))
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

            // ==
            if (pesho1 == pesho2)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);


            Console.WriteLine("Pesho1 HashCode: {0}", pesho1.GetHashCode());
            Console.WriteLine("Pesho2 HashCode: {0}", pesho2.GetHashCode());
            Console.WriteLine();

            var peshoClone = pesho1.Clone();

            Console.WriteLine(peshoClone);
        }
    }
}
