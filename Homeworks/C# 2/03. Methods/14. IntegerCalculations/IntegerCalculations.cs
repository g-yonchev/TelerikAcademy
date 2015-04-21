namespace IntegerCalculations
{
    using System;
    using System.Linq;
    class IntegerCalculations
    {
        /*  Problem 14. Integer calculations

            Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
            Use variable number of arguments.
        */

        static void Main()
        {
            Console.WriteLine("Enter a sequence of integers, separated by space and/or coma:");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            CalculateMinimum(numbers);
            CalculateMaximum(numbers);
            CalculateAverage(numbers);
            CalculateSum(numbers);
            CalculateProduct(numbers);
        }

        static void CalculateMinimum(int[] numbers)
        {
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber < min)
                {
                    min = currentNumber;
                }
            }
            Console.WriteLine("Minimum number: {0}", min);
        }

        static void CalculateMaximum(int[] numbers)
        {
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine("Minimum number: {0}", max);
        }

        static void CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            decimal average = (decimal)sum / (decimal)numbers.Length;

            Console.WriteLine("Average: {0}", average);
        }

        static void CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Sum: {0}", sum);
        }

        static void CalculateProduct(int[] numbers)
        {
            long product = 1;
            foreach (var number in numbers)
            {
                product *= number;
            }

            Console.WriteLine("Product: {0}", product);
        }
    }
}
