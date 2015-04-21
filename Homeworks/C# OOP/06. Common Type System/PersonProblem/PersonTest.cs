/*  Problem 4. Person class
        Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
        Write a program to test this functionality.
*/
namespace PersonProblem
{
    using System;

    public class PersonTest
    {
        public static void Main()
        {
            var pesho = new Person("Pesho", 22);
            var gosho = new Person("Gosho");

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
