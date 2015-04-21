namespace EnglishDigit
{
    using System;
    class Program
    {
        /*  Problem 3. English digit

            Write a method that returns the last digit of given integer as an English word.
            Examples:

            input	    output
            512	        two
            1024	    four
            12309	    nine
        */

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string word = LastDigit(number);
            Console.WriteLine("Last digit: {0}", word); 

        }

        static string LastDigit(int number)
        {
            int lastDigit = number % 10;

            string lastDigintInEnglish = string.Empty;

            switch (lastDigit)
            {
                case 0: lastDigintInEnglish = "zero"; break;
                case 1: lastDigintInEnglish = "one"; break;
                case 2: lastDigintInEnglish = "two"; break;
                case 3: lastDigintInEnglish = "three"; break;
                case 4: lastDigintInEnglish = "four"; break;
                case 5: lastDigintInEnglish = "five"; break;
                case 6: lastDigintInEnglish = "six"; break;
                case 7: lastDigintInEnglish = "seven"; break;
                case 8: lastDigintInEnglish = "eight"; break;
                case 9: lastDigintInEnglish = "nine"; break;
                default: break;
            }

            return lastDigintInEnglish;
        }
    }
}
