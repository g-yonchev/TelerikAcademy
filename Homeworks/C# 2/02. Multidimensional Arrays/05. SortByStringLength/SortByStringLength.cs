namespace SortByStringLength
{
    using System;
    using System.Linq;
    class SortByStringLength
    {
        /*  Problem 5. Sort by string length

            You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
        */

        static void Main()
        {
            string[] array = { "Georgi", "Pesho", "Ivo", "Ivan" };

            var sorted = array
                .OrderBy(x => x.Length)
                .ToArray();

            Console.WriteLine(string.Join(", ", sorted));
        }
    }
}
