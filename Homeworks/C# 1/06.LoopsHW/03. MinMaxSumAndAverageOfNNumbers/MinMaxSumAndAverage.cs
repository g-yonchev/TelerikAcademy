using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        /*  Problem 3. Min, Max, Sum and Average of N Numbers

            Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
            The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
            The output is like in the examples below.
            
            Example 1:

            input	output
            3       min = 1 
            2       max = 5 
            5       sum = 8 
            1       avg = 2.67	 
             
             
            
            Example 2:

            input	output
            2       min = -1 
            -1      max = 4
            4	    sum = 3
                    avg = 1.50
        */

        Console.Title = "Min Max Sum and Average";

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} numbers:", number);
        int input;
        int sum = 0;
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        for (int i = 1; i <= number; i++)
        {
            input = int.Parse(Console.ReadLine());

            sum += input;
            if (input > maxValue)
            {
                maxValue = input;
            }
            if (input < minValue)
            {
                minValue = input;
            }
        }
        double average = (double)sum / (double)number;
        Console.WriteLine("Min = {0}", minValue);
        Console.WriteLine("Max = {0}", maxValue);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Average = {0:F2}", average);
    }
}
