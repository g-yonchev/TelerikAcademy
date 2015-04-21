using System;
class FormattingNumbers
{
    static void Main()
    {
        /*  Problem 5. Formatting Numbers

            Write a program that reads 3 numbers:
            integer a (0 <= a <= 500)
            floating-point b
            floating-point c
            The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
            The number a should be printed in hexadecimal, left aligned
            Then the number a should be printed in binary form, padded with zeroes
            The number b should be printed with 2 digits after the decimal point, right aligned
            The number c should be printed with 3 digits after the decimal point, left aligned.
            Examples:

            a	    b	        c	        result
            254	    11.6	    0.5	        FE |0011111110| 11.60|0.500 |
            499	    -0.5559	    10000	    1F3 |0111110011| -0.56|10000 |
            0	    3	        -0.1234	    0 |0000000000| 3|-0.123 |
        */

        Console.Title = "Formatting Numbers";

        Console.Write("Enter integer number a (between 0 and 500): ");
        int firstNumber = int.Parse(Console.ReadLine());

        if (firstNumber > 0 && firstNumber < 500)
        {
            Console.Write("Enter real number b: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter real number c: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            string inHexadecimal = Convert.ToString(firstNumber, 16);
            string inBinary = Convert.ToString(firstNumber, 2).PadLeft(16, '0');
            Console.WriteLine("{0,10}|{1,10}|{2,10:F2}|{3,10:F3}", inHexadecimal, inBinary, secondNumber, thirdNumber); 
        }
        else
        {
            Console.WriteLine("Wrong number!!!");
        } 
    }
}