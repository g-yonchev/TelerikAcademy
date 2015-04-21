/*  Problem 1. Square root

    Write a program that reads an integer number and calculates and prints its square root.
        If the number is invalid or negative, print Invalid number.
        In all cases finally print Good bye.
    Use try-catch-finally block.
*/

namespace SquareRoot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                double root = Sqrt(number);
                Console.WriteLine("Square root: {0}", root);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number! You entered text or something.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number! The number is negative");
            }
            
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }

        private static double Sqrt(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();                
            }
            return Math.Sqrt(number);
        }
    }
}
