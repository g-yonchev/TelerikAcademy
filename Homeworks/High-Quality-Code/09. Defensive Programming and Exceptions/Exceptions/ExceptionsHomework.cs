namespace Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] array, int startIndex, int count)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array", "Array cannot be null.");
            }

            if (startIndex < 0 || startIndex >= array.Length)
            {
                throw new IndexOutOfRangeException(string.Format("Start index must be between 0 and {0}.", array.Length));
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("Count", "Length of subsequence should be positive.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(array[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("Input string", "String cannot be null.");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("Count", "Count should be less than the length of the input string.");
                ////or
                ////return str;
                ////depends of the case :-)
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
            //// or
            //// return str.Substring(str.Length - count, str.Length);
        }

        public static bool IsPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main()
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            ////Console.WriteLine(ExtractEnding("Hi", 100));

            int firstNumber = 23;
            int secondNumber = 33;
            Console.WriteLine(firstNumber + " is prime?: " + IsPrime(firstNumber));
            Console.WriteLine(secondNumber + " is prime?: " + IsPrime(secondNumber));

            List<Exam> peterExams = new List<Exam>()
        {
            new MathExam(3),
            new CSharpExam(55),
            new CSharpExam(100),
            new MathExam(1),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalculateAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
