namespace _GetLargestNumber
{
    using System;
    class GetLargestNumber
    {
        /*  Problem 2. Get largest number

            Write a method GetMax() with two parameters that returns the larger of two integers.
            Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
        */


        static void Main()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            
            int max;

            max = GetMax(a, b);

            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());

            max = GetMax(c, max);

            Console.WriteLine("Max number: {0}", max);
            
        }

        static int GetMax(int a, int b)
        {
            int max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            return max;
        }
    }
}
