/*  Problem 6. Divisible by 7 and 3

    Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/

namespace DivisiblebySevenAndThree
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    static class Test
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 3, 5, 7, 21, 22, 29, 42 };
            Console.WriteLine(String.Join(", ", numbers.DivisibleByLambda(3, 7)));
            Console.WriteLine(String.Join(", ", numbers.DivisibleByLINQ(3, 7)));

        }

        private static IEnumerable<int> DivisibleByLambda(this IEnumerable<int> numbers, int divider1, int divider2)
        {
            var result = numbers
                .Where(n => n % divider1 == 0 && n % divider2 == 0);
            return result;
        }

        private static IEnumerable<int> DivisibleByLINQ(this IEnumerable<int> numbers, int divider1, int divider2)
        {
            var result =
                from n in numbers
                where (n % divider1 == 0 && n % divider2 == 0)
                select n;
            return result;
        }
    }
}
