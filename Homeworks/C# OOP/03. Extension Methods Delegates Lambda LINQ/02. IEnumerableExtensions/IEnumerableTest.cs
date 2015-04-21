/*  Problem 2. IEnumerable extensions

    Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
*/

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class IEnumerableTest
    {
        static void Main()
        {
            IEnumerable<int> someCollection = new List<int> { 1, 2, 3, 4, 0, -100 };
            int sum = someCollection.IEnumerableSum(); // -90
            int product = someCollection.IEnumerableProduct(); // 0
            int min = someCollection.IEnumerableMin(); // -100
            int max = someCollection.IEnumerableMax(); // 4
            double avr = someCollection.IEnumerableAverage(); // -15.0


            Console.WriteLine(string.Join(", ", someCollection));

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Average: " + avr);
        }
    }
}
