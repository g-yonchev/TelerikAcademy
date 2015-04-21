/*  Problem 2. Enter numbers

    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

namespace EnterNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    int n = ReadInteger();
                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }

        private static int ReadInteger()
        {
            Console.Write("Enter number in range [1...100]: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 1 || number >= 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number;
        }
    }
}
