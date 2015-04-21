using System;

class OddAndEvenProduct
{
    static void Main()
    {
        /*  Problem 10. Odd and Even Product

            You are given n integers (given in a single line, separated by a space).
            Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
            Examples:

            numbers	        result
            2 1 1 6 3	    yes
            product = 6	

            3 10 4 6 5 1	yes
            product = 60	

            4 3 2 5 2	    no
            odd_product = 16	
            even_product = 15	
         */

        Console.Title = "Odd and Even Product";

        Console.WriteLine("Enter numbers in a single line, separated by a space (' '):");
        string[] numbers = Console.ReadLine().Split(' ');

        long productOdd = 1;
        long productEven = 1;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            long number = long.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                productEven *= number;
            }
            else
            {
                productOdd *= number;
            }
        }

        if (productEven == productOdd)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("The product of the odd elements is equal to the product.");
            Console.WriteLine("Odd and even elements product: {0}", productEven);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("The product of the odd elements is not equal to the product.");
            Console.WriteLine("Odd elements product: {0}", productOdd);
            Console.WriteLine("Even elements product: {0}", productEven);
        }
        
        
    }
}