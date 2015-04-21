namespace AddingPolynomials
{
    using System;
    class AddingPolynomials
    {
        /*  Problem 11. Adding polynomials

            Write a method that adds two polynomials.
            Represent them as arrays of their coefficients.
            Example:

            x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
        */

        static void Main()
        {
            decimal[] firstPolynomial = { 5, -1 };
            Console.Write("First Polynomial: ");
            PrintPolynomial(firstPolynomial);

            decimal[] secondPolynomial = { 10, -5, 6 };
            Console.Write("Second Polynomial: ");
            PrintPolynomial(secondPolynomial);

            int maxLength = 0;
            if (firstPolynomial.Length > secondPolynomial.Length)
            {
                maxLength = firstPolynomial.Length;
            }
            else
            {
                maxLength = secondPolynomial.Length;
            }

            decimal[] result = new decimal[maxLength];

            Sum(firstPolynomial, secondPolynomial, result);

            Console.Write("Sum: ");
            PrintPolynomial(result);
        }

        static void Sum(decimal[] first, decimal[] second, decimal[] result)
        {
            int minLenght = 0;
            int smallerPoly = 0;

            if (first.Length > second.Length)
            {
                minLenght = second.Length;
                smallerPoly = 2;
            }
            else
            {
                minLenght = first.Length;
                smallerPoly = 1;
            }

            for (int i = 0; i < minLenght; i++)
            {
                result[i] = first[i] + second[i];
            }

            for (int i = minLenght; i < result.Length; i++)
            {
                if (smallerPoly == 1)
                {
                    result[i] = second[i];
                }
                else
                {
                    result[i] = first[i];
                }
            }
        }

        static void PrintPolynomial(decimal[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0 && i != 0)
                {
                    if (polynomial[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} + ", i, polynomial[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, polynomial[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.WriteLine(polynomial[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
